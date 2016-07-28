create or replace view AvailableDoctors
AS 
Select D.DID,D.Title, D.FName, D.LName, S.SID, Sch.StartTime, Sch.Date 
From Doctor as D JOIN Speciality as S JOIN Doc_Spec as DS JOIN Schedule as Sch
ON D.DID = DS.DID AND DS.SID = S.SID AND Sch.DID = D.DID
where D.DID IN (
	select DID 
    From Schedule 
    where Status = 2
);

drop procedure AvailableDoctors;

DELIMITER //
create procedure AvailableDoctors()
BEGIN
	Select distinct(DID), concat(Title,FName,' ',LName) from AvailableDoctors;
END //
DELIMITER ;

DELIMITER //
create procedure AvailableDoctorsForSpecialization(vSID int)
BEGIN
	Select DID, concat(Title,'', FName,' ', LName) from AvailableDoctors where SID = vSID;
END //
DELIMITER ;

DELIMITER //
create procedure AllDoctors()
BEGIN
	Select distinct(DID), concat(Title,FName,' ',LName) from Doctor;
END //
DELIMITER ;

select * from speciality;


DELIMITER //
create procedure FindRooms(vDateToFind date, searchStartTime time, searchEndTime time)
BEGIN
		DECLARE $StartIndex int; 		# Contains the start index of the starting row in the availalbe schedules
		DECLARE $EndIndex int;   		# Contains the Last index of the starting row in the availalbe schedules
        DECLARE $CenterStartTime time ; # This is the time when Medical Center Starts 
		DECLARE $CenterEndTime time ;	# This is the time when Medical Center Ends
		DECLARE $NumOfRooms int;
        DECLARE countIndex int ;
        
		set $CenterStartTime = '080000';
        set $CenterEndTime = '2000000';
        
        
		 Select S.SchID into $StartIndex from (
						select * from Schedule where Status = 2
					   ) AS S 
		 where S.Date = vDateToFind
		 LIMIT 1;		 
             
		 
		 Select S.SchID into $EndIndex from (
						select * from Schedule where Status = 2
					   ) AS S 
		 where S.Date = vDateToFind 
		 ORDER BY S.SchID desc
		 LIMIT 1;
    
		create temporary table AvailableSlots
		(
			Date date,
			StartTime time,
			EndTime time,
            Room varchar(20),
            RoomID int
		);
        # Inserting the First row of the Current Schedules into availableSlots
		 insert into AvailableSlots (Date, StartTime, EndTime, Room, RoomID)
    
		 (select S.Date, $CenterStartTime, S.StartTime, (select Name from Room where RoomID = S.RoomID),S.RoomID from (
						select * from Schedule where Status = 2
					   ) AS S 
		 where S.Date = vDateToFind
         LIMIT 1)
	UNION
		 (select S.Date, S.EndTime, 
						 (
							 select StartTime 
							 from Schedule 
							 where status = 2 AND SchID > S.SchID LIMIT 1
                         ) , (select Name from Room where RoomID = S.RoomID),S.RoomID
					   from 
					   (
							select * from Schedule where Status = 2
					   ) AS S
         where S.Date = vDateToFind
         LIMIT 1)
         ;
         
         # Inserting all rows between first and last rows of the Current Schedules into availableSlots
         
         insert into AvailableSlots (Date, StartTime, EndTime, Room, RoomID)
    
		 select S.Date, S.EndTime, 
						 (
							 select StartTime 
							 from Schedule 
							 where status = 2 AND SchID > S.SchID LIMIT 1
                         ) 
                         , (select Name from Room where RoomID = S.RoomID),S.RoomID
					   from 
					   (
							select * from Schedule where Status = 2
					   ) AS S
                       
		 where S.Date = vDateToFind AND S.SchID > $StartIndex AND S.SchID < $EndIndex;
         
         # Inserting the Last row of the Current Schedules into availableSlots
         
         insert into AvailableSlots (Date, StartTime, EndTime, Room, RoomID)
    
		 select S.Date, S.EndTime, $CenterEndTIme, (select Name from Room where RoomID = S.RoomID),S.RoomID from (
						select * from Schedule where Status = 2
					   ) AS S 
		 where S.Date = vDateToFind
         Order by S.SchID Desc
         LIMIT 1;
         
         # Selecting all in AvailableSlots table
		
		
        
        set $NumOfRooms = (select count(RoomID) from Room);
        
        
        set countIndex = 1;
        
        while(countIndex <= $NumOFRooms) DO
			if((select count(Room) from AvailableSlots as A where (Select RoomID from Room where Name = A.Room) = countIndex) = 0) THEN
				insert into AvailableSlots (Date, StartTime, EndTime, Room,RoomID) 
                values (vDateToFind, searchStartTime, searchEndTime, (Select Name from Room where RoomID = countIndex), countIndex);
			end if;
            set countIndex = countIndex + 1;
		end while;
        
       
         Select RoomID, Room from AvailableSlots
		 where time_to_sec(searchStartTime) <= time_to_sec(StartTime) AND time_to_sec(searchEndTime) >= time_to_sec(StartTime)         
		order by StartTime, Room ;
         
         drop table AvailableSlots;
     
END // 
DELIMITER ;