use AMC;

create table Schedule
(
	SchID int primary key auto_increment,
    Date date not null,
    StartTime time not null,
    EndTime time not null,
    MaxPatients int not null,
    Status int(1), 
    DID int references Doctor(DID),
    RoomID int references room(RoomID)
);

call AddSchedule ('2016-08-03', '080000', '090000', '20', 19, 1);
drop procedure AddSchedule;

DELIMITER // 
create procedure AddSchedule(
	vDate date ,
    vStartTime time,
    vEndTime time,
    vMaxPatients varchar(2),
    vDID int,
    vRoomID int
    )
BEGIN

    IF ( select vDate < CURDATE()) then
		SIGNAL SQLSTATE '45000'
		SET MESSAGE_TEXT = 'Invalid Date';
    END IF;   
    
	IF ( select vMaxPatients NOT REGEXP '^[0-9]{1,2}$') then
		SIGNAL SQLSTATE '45000'
		SET MESSAGE_TEXT = 'Invalid Title';
    END IF;   
    
	insert into Schedule (
		Date,
		StartTime,
		EndTime,
		MaxPatients,
		Status, 
		DID,
        RoomID
    )
    values (
    vDate,
    vStartTime,
    vEndTime,
    vMaxPatients,
    2,
    vDID,
    vRoomID
    );
END //
DELIMITER ;

DELIMITER // 
create procedure UpdateSchedule(
	
	vSchID int,
    vDate date,
    vStartTime time,
    vEndTime time,
    vMaxPatients int,
    vDID int
)

BEGIN

	update Schedule set 
    Date = vDate,
    StartTime = vStartTime,
    EndTime = vEndTime,
    MaxPatients = vMaxPatients,
    DID = vDID
    
    where SchID = vSchID;    

END //
DELIMITER ;

DELIMITER //
create procedure CancelSchedule(vSchID int)
BEGIN
 update Schedule set Status = 1 where SchID = VSchID;
 update Appoinment set status = 1 where SchID = VSchID; 
END //
DELIMITER ;

DELIMITER // 
create procedure SetScheduleStatus(vSchID int, vStatus int)
BEGIN 
	update Schedule set Status = vStatus where SchID = vSchID;
END // 
DELIMITER ;

drop procedure SearchSchedules;
DELIMITER //
create procedure SearchSchedules(vDID int,startDate date,endDate date)
begin
	if (vDID != -1) THEN
		select S.SchID,
        concat((Select concat(Title,'', D.Fname, ' ', D.Lname) from Doctor as D where D.DID = S.DID) , ' | ', S.Date,' | ', S.StartTime,' | ', S.EndTime,' ' )
        ,S.DID
        from Schedule as S
		where S.Status = 2 AND S.DID = vDID AND S.Date >= startDate AND S.Date <= endDate  ;
    ELSE 
		select S.SchID,
        concat((Select concat(Title,'', D.Fname, ' ', D.Lname) from Doctor as D where D.DID = S.DID), ' | ' , S.Date,' | ', S.StartTime,' | ', S.EndTime,' ' )
        ,S.DID
        from Schedule as S
		where S.Status = 2 AND S.Date >= startDate AND S.Date <= endDate  ;
    END IF;
end //
DELIMITER ;

select * from Appointment;
DELIMITER //
create procedure GetSchedulesForDay(vDateToFind date)
BEGIN 

    
	select S.SchID into resultset from (
					select * from Schedule where Status = 2
				   ) AS S 
     where S.Date = vDateToFind;
END //
DELIMITER ;
select * from Room;

drop procedure GetFreeSlotsForADay1;

DELIMITER //
create procedure GetFreeSlotsForADay1(vDateToFind date, searchStartTime time, searchEndTime time)
BEGIN
		DECLARE $StartIndex int; 		# Contains the start index of the starting row in the availalbe schedules
		DECLARE $EndIndex int;   		# Contains the Last index of the starting row in the availalbe schedules
        DECLARE $CenterStartTime time ; # This is the time when Medical Center Starts 
		DECLARE $CenterEndTime time ;	# This is the time when Medical Center Ends
		DECLARE $NumOfRooms int;
        DECLARE countIndex int ;
        
		set $CenterStartTime = '080000';
        set $CenterEndTime = '200000';
        
        
		set $StartIndex = 1;
             
		 
		 Select count(S.SchID) into $EndIndex from (
						select * from Schedule where Status = 2
					   ) AS S
		 where S.Date = vDateToFind ;		 
		
    
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
		 where S.Date = vDateToFind order by StartTime, EndTime
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
         where S.Date = vDateToFind order by StartTime, EndTime
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
		 where S.Date = vDateToFind AND rownum() > $StartIndex AND rownum() < $EndIndex;
         
         # Inserting the Last row of the Current Schedules into availableSlots
         
         insert into AvailableSlots (Date, StartTime, EndTime, Room, RoomID)
    
		 select S.Date, S.EndTime, $CenterEndTIme, (select Name from Room where RoomID = S.RoomID),S.RoomID from (
						select * from Schedule where Status = 2
					   ) AS S 
		 where S.Date = vDateToFind
         Order by StartTime, EndTime Desc
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
        
       
         Select * from AvailableSlots
		 where time_to_sec(searchStartTime) <= time_to_sec(StartTime) AND time_to_sec(searchEndTime) >= time_to_sec(StartTime)         
		order by StartTime, Room ;
         
         drop table AvailableSlots;
     
END // 
DELIMITER ;
select * from Schedule where status = 2 order by StartTime, EndTime;
drop procedure GetFreeSlotsForTheWeek;

select SchID,rownum() from Schedule where SchID = 6;

call GetFreeSlotsForADay('2016-05-26', '080000', '200000');
call GetFreeSlotsForADay1('2016-07-28', '160000', '190000');
call GetFreeSlotsForTheWeek('2016-05-26',3);

select * from Room;
truncate Schedule;
insert into Schedule (Date, StartTime, EndTime, MaxPatients, Status, DID)
Values ('2016-05-26','083000','103000',5,2,1);
insert into Schedule (Date, StartTime, EndTime, MaxPatients, Status, DID)
Values ('2016-05-26','133000','143000',5,2,1);
insert into Schedule (Date, StartTime, EndTime, MaxPatients, Status, DID)
Values ('2016-05-27','083000','103000',5,2,1);
insert into Schedule (Date, StartTime, EndTime, MaxPatients, Status, DID)
Values ('2016-05-28','083000','103000',5,2,1);
insert into Schedule (Date, StartTime, EndTime, MaxPatients, Status, DID)
Values ('2016-05-29','083000','103000',5,2,1);
insert into Schedule (Date, StartTime, EndTime, MaxPatients, Status, DID)
Values ('2016-05-30','083000','103000',5,2,1);
insert into Schedule (Date, StartTime, EndTime, MaxPatients, Status, DID)
Values ('2016-05-31','083000','103000',5,2,1);
insert into Schedule (Date, StartTime, EndTime, MaxPatients, Status, DID)
Values ('2016-06-01','083000','103000',5,2,1);
insert into Schedule (Date, StartTime, EndTime, MaxPatients, Status, DID)
Values ('2016-05-26','083000','103000',5,2,1);
insert into Schedule (Date, StartTime, EndTime, MaxPatients, Status, DID)
Values ('2016-05-26','083000','103000',5,2,1);


UPDATE `amc`.`schedule` SET `RoomID`= 1 WHERE `SchID`='1';
UPDATE `amc`.`schedule` SET `RoomID`= 1 WHERE `SchID`='2';
UPDATE `amc`.`schedule` SET `RoomID`= 1 WHERE `SchID`='3';
UPDATE `amc`.`schedule` SET `RoomID`= 3 WHERE `SchID`='4';
UPDATE `amc`.`schedule` SET `RoomID`= 1 WHERE `SchID`='5';
UPDATE `amc`.`schedule` SET `RoomID`= 2 WHERE `SchID`='6';
UPDATE `amc`.`schedule` SET `RoomID`= 2 WHERE `SchID`='7';
UPDATE `amc`.`schedule` SET `RoomID`= 1 WHERE `SchID`='8';
UPDATE `amc`.`schedule` SET `RoomID`= 2 WHERE `SchID`='9';
UPDATE `amc`.`schedule` SET `RoomID`= 2 WHERE `SchID`='10';



insert into Room (Name) values ('Room 1');
insert into Room (Name) values ('Room 2');
insert into Room (Name) values ('Room 3');

select * from Room;


select * from Schedule;