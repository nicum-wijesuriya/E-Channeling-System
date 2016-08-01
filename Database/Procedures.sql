use AMC;

#Appointment
DELIMITER // 
create procedure AddAppointment(
    vPID int,
	vSchID int
    )

BEGIN

	Declare vQueNo int;
    Declare vtime time;
    Declare vFee double;
    Declare vDate date;
    Declare vDID int;

	set vQueNo = getQueueNo(vSchID);
    set vTime = getTime(vSchID);
    set vFee = getFee (vSchID);
    set vDate = (select Date from Schedule where SchID = vSchID);
    set vDID = (select DID from Schedule where SchID = vSchID);
    
	insert into Appointment (
	PID,
    DID,
	SchID,
    Date,   
    Fee,
    Status,
    QueNo,
    Time
    )
    values (
    vPID,
    vDID,
	vSchID,
    vDate,   
    vFee,
    2,
    vQueNo,
    vTime
    );
    
    select RefID from Appointment order by RefID desc Limit 1;
END //
DELIMITER ;

DELIMITER // 
create procedure UpdateAppointment(
    vRefID int,
	vSchID int
)

BEGIN

	Declare vQueNo int;
    Declare vtime time;
    Declare vFee double;
    Declare vDate date;
    Declare vDID int;

	set vQueNo = getQueueNo(vSchID);
    set vTime = getTime(vSchID);
    set vFee = getFee (vSchID);
    set vDate = (select Date from Schedule where SchID = vSchID);
    set vDID = (select DID from Schedule where SchID = vSchID);
    
	update Appointment set 
    DID = vDID,
	SchID = vSchID,
    Date = vDate,
    Time = vTime,
	QueNo = vQueNo,
    Fee = vFee
    
    where RefID = vRefID;    

END //
DELIMITER ;

call UpdateAppointment(1,3);

drop procedure CancelAppointment;
drop procedure CloseAppointment;

call CancelAppointment(1);
DELIMITER //
create procedure CancelAppointment(vRefID int)
BEGIN
	update Appointment set status = 1 where RefID = VRefID; 
END //
DELIMITER ;

DELIMITER //
create procedure CloseAppointment(vRefID int)
BEGIN
	update Appointment set status = 3 where RefID = VRefID; 
END //
DELIMITER ;
drop procedure FindAppoinment;
DELIMITER //
create procedure FindAppoinment(vRefID int)
BEGIN
	select (Select P.NICNo from Patient as P where P.PID = A.PID) as NICNo,
			(Select concat(D.Title,D.FName,' ',D.LName) from Doctor as D where D.DID = A.DID) as DocName,
            A.Date as SchDate, A.Time as SchTime,A.QueNo as QueNo,
            (Select R.Name from Room as R where R.RoomID = (Select S.RoomID from Schedule as S where A.SchID = S.SchID )) as Room,
            A.Fee as Fee, A.DID
    from Appointment as A
    where A.RefID = vRefID;
END//
DELIMITER ;

DELIMITER //
create function getQueueNo (vSchID int) returns int 
    
BEGIN
    
	Declare QueueNo int default 0;
    
    select QueNo into QueueNo
    from Appointment
    where SchID = vSchID
    order by QueNo desc 
    limit 1;
    
    return (QueueNo +1);
    
END //
DELIMITER ;

DELIMITER //
create function getTime (vSchID int) returns time 
    
BEGIN
    
	Declare QueueNo int default 0;
	Declare sTime time;
	Declare eTime time;
	Declare mPatients int;
    Declare avrTime time;
    Declare appTime time;
    Declare extraTime int; #extra time to arrive early (seconds)
    
    set QueueNo = getQueueNo(vSchID);
    set extraTime = 1200;
    
    select startTime, endTime, maxPatients into sTime, eTime, mPatients
    from Schedule
    where SchID = vSchID;
    
  # set avrTime = sec_to_time(Time_to_sec(eTime -sTime) / mPatients);
    set avrTime =(time_to_sec(eTime) -time_to_sec(sTime))/mPatients;
  #  select avrTime;
    set appTime = sec_to_time(time_to_sec(sTime) + avrTime * (QueueNo-1) - extraTime);
    
    return appTime;
    
END //
DELIMITER ;

DELIMITER //

create function getFee(vSchID int) returns double

BEGIN

	Declare Fee double(8,2);
    Declare hosFee double(8,2); #Hospital charges
    Declare docFee double(8,2); #Doctor's fee
    
    set hosFee = 100.00;
    
    set docFee = ( 
		select d.Fee 
        from Doctor as d, Schedule as s
        where s.SchID = vSchID and d.DID = s.DID
	);
    
    
    set Fee = hosFee + docFee;
    
    return Fee;

END //

DELIMITER ;

DELIMITER //
create procedure FindAppointmentByID(vRefID int)
BEGIN
	Select A.RefID, (Select concat(Title,FName, LName) from Doctor where DID = A.DID), A.Date, A.Time,A.QueNo,A.Fee, (Select Email from Patient where PID = A.PID) from appointment as A where RefID = vRefID;
END //
DELIMITER ;

#Doc_Spec
DELIMITER // 
create procedure InsertDocSpec(vDID int, vSID int)
BEGIN
	insert into Doc_Spec values(vDID, vSID);
END //
DELIMITER ;

DELIMITER //
create procedure UpdateDoctorsSpeciality(vDID int, oldSID int, newSID int)
BEGIN
	update Doc_Spec set SID = newSID where SID = oldSID AND DID = vDID;
END
DELIMITER ;

DELIMITER //
create procedure SpecializationsForDoctor(vDID int)
BEGIN
	Select SID, Name from speciality where DID = vDID;
END //
DELIMITER ;

#Doctor
DELIMITER //
create procedure AddDoctor (
	vTitle varchar(11),
	vFName varchar(15),
    vLName varchar(30),
    vContact int(10),
	vEmail varchar(50),
	vFee double(8,2)
)

Begin
	
    insert into Doctor (Title, FName, LName, Contact, Email, Fee)
    values (vTitle, vFName, vLName, vContact, vEmail, vFee);

END //
DELIMITER ;

DELIMITER //
create procedure UpdateDoctor (
	vDID int,
    vTitle varchar(11),
	vFName varchar(15),
    vLName varchar(30),
    vContact int(10),
	vEmail varchar(50),
	vFee double(8,2)
    
)

Begin
	update Doctor set 
    Title = vTitle,
	Fname = vFName,
    LName = vLName,
    Contact = vContact,
	Email = vEmail,
	Fee = vFee
    where DID = vDID;
    
   
END //
DELIMITER ;

DELIMITER //
create procedure DeleteDoctor (vDID int)

Begin
	update Doctor set 
    isDeleted = true where DID = vDID;
   
END //
DELIMITER ;
DELIMITER //
create procedure RecoverDoctor (vDID int)

Begin
	update Doctor set 
    isDeleted = false where DID = vDID;
   
END //
DELIMITER ;

DELIMITER //
create procedure AllDoctors()
BEGIN
	Select distinct(DID), concat(Title,FName,' ',LName) from Doctor;
END //
DELIMITER ;


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

#Patient
DELIMITER //
create procedure AddPatient (

    vTitle varchar(11),	
    vFName varchar(15),
    vLName varchar(30),
    vANumber varchar(25),
    vAStreet varchar(25),
    vACity varchar(25),
    vEmail varchar(50),
    vNICNo varchar(10),
    vCMobile int(10),
    vCHome int(10),
    vIsLocal bool

)

Begin 

	insert into Patient (FName,LName,ANumber, AStreet,ACity,Email,NICNo,Title,CMobile,CHome,IsLocal) 
	values (vFName,vLName,vANumber,vAStreet,vACity,vEmail,vNICNo,vTitle,vCMobile,vCHome,vIsLocal);
	Select PID from patient order by PID desc LIMIT 1 ;
END //
DELIMITER ;

DELIMITER //
create procedure UpdatePatient (
	vPID int,    
    vTitle varchar(11),
	vFName varchar(15),
    vLName varchar(30),
    vANumber varchar(25),
    vAStreet varchar(25),
    vACity varchar(25),
    vEmail varchar(50),
    vNICNo varchar(10),
    vCMobile int(10),
    vCHome int(10),
    vIsLocal bool

)
BEGIN 
	update Patient set 
    FName = vFName,
    LName = vLName,
    ANumber = vANumber,
    AStreet = vAStreet,
    ACity = vACity,
    Email = vEmail,
    NICNo = vNICNo,
    Title = vTitle,
    CMobile = vCMobile,
    CHome = vCHome,
    IsLocal = vIsLocal 
    Where 
    PID = vPID;
END //
DELIMITER ;

DELIMITER // 
create procedure DeletePatient(vPID int)
BEGIN 
	update Patient set isDeleted = true where PID = vPID;
END //
DELIMITER ;

DELIMITER // 
create procedure RecoverPatient(vPID int)
BEGIN 
	update Patient set isDeleted = false where PID = vPID;
END //
DELIMITER ;
select * from Patient;

DELIMITER //
create procedure SelectPatient(vNICNO varchar(10))
BEGIN
	select * from Patient where NICNo = vNICNo;
END //
DELIMITER ;

#Schedule
DELIMITER // 
create procedure AddSchedule(
	vDate date ,
    vStartTime time,
    vEndTime time,
    vMaxPatients int,
    vStatus int(1), 
    vDID int 
    )
BEGIN
	insert into Schedule (
		Date,
		StartTime,
		EndTime,
		MaxPatients,
		Status, 
		DID
    )
    values (
    vDate,
    vStartTime,
    vEndTime,
    vMaxPatients,
    vStatus, 
    vDID
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

DELIMITER //
create procedure GetSchedulesForDay(vDateToFind date)
BEGIN 

    
	select S.SchID into resultset from (
					select * from Schedule where Status = 2
				   ) AS S 
     where S.Date = vDateToFind;
END //
DELIMITER ;

DELIMITER //
create procedure GetFreeSlotsForADay(vDateToFind date, searchStartTime time, searchEndTime time)
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
            Room varchar(20)
		);
        # Inserting the First row of the Current Schedules into availableSlots
		 insert into AvailableSlots (Date, StartTime, EndTime, Room)
    
		 (select S.Date, $CenterStartTime, S.StartTime, (select Name from Room where RoomID = S.RoomID) from (
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
                         ) , (select Name from Room where RoomID = S.RoomID)
					   from 
					   (
							select * from Schedule where Status = 2
					   ) AS S
         where S.Date = vDateToFind
         LIMIT 1)
         ;
         
         # Inserting all rows between first and last rows of the Current Schedules into availableSlots
         
         insert into AvailableSlots (Date, StartTime, EndTime, Room)
    
		 select S.Date, S.EndTime, 
						 (
							 select StartTime 
							 from Schedule 
							 where status = 2 AND SchID > S.SchID LIMIT 1
                         ) 
                         , (select Name from Room where RoomID = S.RoomID)
					   from 
					   (
							select * from Schedule where Status = 2
					   ) AS S
                       
		 where S.Date = vDateToFind AND S.SchID > $StartIndex AND S.SchID < $EndIndex;
         
         # Inserting the Last row of the Current Schedules into availableSlots
         
         insert into AvailableSlots (Date, StartTime, EndTime, Room)
    
		 select S.Date, S.EndTime, $CenterEndTIme, (select Name from Room where RoomID = S.RoomID) from (
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
				insert into AvailableSlots (Date, StartTime, EndTime, Room) 
                values (vDateToFind, searchStartTime, searchEndTime, (Select Name from Room where RoomID = countIndex));
			end if;
            set countIndex = countIndex + 1;
		end while;
         Select * from AvailableSlots
		 where time_to_sec(searchStartTime) <= time_to_sec(StartTime) AND time_to_sec(searchEndTime) >= time_to_sec(StartTime)
         
		order by StartTime, Room ;
         
         drop table AvailableSlots;
     
END // 
DELIMITER ;

#Speciality
DELIMITER //
create procedure AddSpeciality (
	vName varchar(60)
)
BEGIN
	insert into Speciality (Name) values (vName);
    select SID, Name from speciality order by SID desc Limit 1;
END //
DELIMITER ;

DELIMITER //
create procedure UpdateSpeciality ( 
	vSID int,
    vName varchar(60)
)
BEGIN
	update Speciality set Name = vName where SID = vSID;
END //
DELIMITER ;

DELIMITER // 
create procedure DeleteSPeciality(vSID int)
BEGIN
	delete from Speciality where SID = vSID;
END // 
DELIMITER ;


DELIMITER // 
create procedure GetAllSpeciality()
BEGIN
	select * from Speciality;
END // 
DELIMITER ;

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

