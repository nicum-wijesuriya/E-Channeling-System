use AMC;

create table Appointment
(
	RefID int primary key auto_increment,
    PID int references Patient(PID),
    DID int references Doctor(DID),
	SchID int references Schedule(SchID),
    Date date not null,
    Time time not null,
    QueNo int not null,
    Fee double(8,2),
    Status int(1)
    
);
call AddAppointment(1,13);
select * from appointment;


drop procedure AddAppointment;

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
    
    IF ( select vPID NOT REGEXP '^[0-9]+$') then
		SIGNAL SQLSTATE '45000'
		SET MESSAGE_TEXT = 'Invalid PID';
    END IF; 
    
    IF NOT exists( select * from Patient where PID = vPID ) then
		SIGNAL SQLSTATE '45000'
		SET MESSAGE_TEXT = 'Patient not Registered';
    END IF; 
    
    
    
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

drop procedure UpdateAppointment;


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
select * from Appointment;
call CancelAppointment(3);
DELIMITER //
create procedure CancelAppointment(vRefID int)
BEGIN
	update Appointment set status = 1 where RefID = vRefID; 
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

select * from appointment;
select * from Schedule;
call FindAppoinment(2);
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


drop function getTime;
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
    set avrTime =sec_to_time((time_to_sec(eTime) -time_to_sec(sTime))/mPatients);
  #  select avrTime;
    set appTime = sec_to_time(time_to_sec(sTime) + time_to_sec(avrTime) * (QueueNo-1) - extraTime);
    
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
select * from APpointment;

drop procedure FindAppointmentByID;
DELIMITER //
create procedure FindAppointmentByID(vRefID int)
BEGIN
	Select A.RefID, (Select concat(Title, ' ', FName, ' ', LName) from Doctor where DID = A.DID), A.Date, A.Time,
    A.QueNo,A.Fee, (Select Email from Patient where PID = A.PID) 
    from appointment as A 
    where RefID = vRefID;
END //
DELIMITER ;

drop procedure AllAppointments;
DELIMITER //
create procedure AllAppointments()
BEGIN
	Select A.RefID, (Select concat(Title,' ',FName,' ', LName) from Doctor where DID = A.DID), A.SchID, 
    A.Date, A.Time, A.QueNo, (Select concat(Title, ' ',FName, ' ', LName) from Patient where PID = A.PID),
    (Select NICNo from Patient where PID = A.PID)
    from appointment as A;
END //
DELIMITER ;

call AllAppointments();

select * from Appointment;
select getTime(1);

drop function getFee;
drop function getTime;