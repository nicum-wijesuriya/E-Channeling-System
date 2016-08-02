use AMC;

create table Patient
(
	PID int primary key auto_increment,
    FName varchar(15) not null,
    LName varchar(30) not null,
    ANumber varchar(25),
    AStreet varchar(25),
    ACity varchar(25),
    Email varchar(50),
    NICNo varchar(10) not null,
    Title varchar(9),
    CMobile int(10),
    CHome int(10),
    IsLocal bool,
    isDeleted bool default false
);
Alter table patient modify Title varchar(11);

drop procedure AddPatient;
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
    vCMobile varchar(10),
    vCHome varchar(10),
    vIsLocal bool

)

Begin 
	  IF ( select vCMobile NOT REGEXP '^0{0,1}7[0-9]{8}$') then
		SIGNAL SQLSTATE '45000'
		SET MESSAGE_TEXT = 'Invalid Contact Number';
    END IF;
    
    IF ( select vCHome NOT REGEXP '^0{0,1}[0-9]{9}$') then
		SIGNAL SQLSTATE '45000'
		SET MESSAGE_TEXT = 'Invalid Home Number';
    END IF;
    
    IF ( select vNICNo NOT REGEXP '^([0-9]{9}(V|X|v|x)|[0-9]{12})+$') then
		SIGNAL SQLSTATE '45000'
		SET MESSAGE_TEXT = 'Invalid NIC Number';
    END IF;
     
    IF ( select vEmail NOT REGEXP '^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$') then
		SIGNAL SQLSTATE '45000'
		SET MESSAGE_TEXT = 'Invalid Email Address';
    END IF;
    
    IF ( vFName = '' OR vFName NOT REGEXP '^([\w|\s])+$') then
		SIGNAL SQLSTATE '45000'
		SET MESSAGE_TEXT = 'Invalid First name';
    END IF;
    
    IF ( vLName = '' OR vLName NOT REGEXP '^([\w|\s])+$') then
		SIGNAL SQLSTATE '45000'
		SET MESSAGE_TEXT = 'Invalid Last name';
    END IF;
    
    IF ( vANumber = '' ) then
		SIGNAL SQLSTATE '45000'
		SET MESSAGE_TEXT = 'Address Number cannot be empty';
    END IF;
    IF ( vACity = '') then
		SIGNAL SQLSTATE '45000'
		SET MESSAGE_TEXT = 'Address City cannot be empty';
    END IF;
    IF ( vAStreet = '') then
		SIGNAL SQLSTATE '45000'
		SET MESSAGE_TEXT = 'Address Streey cannot be empty';
    END IF;
	insert into Patient (FName,LName,ANumber, AStreet,ACity,Email,NICNo,Title,CMobile,CHome,IsLocal) 
	values (vFName,vLName,vANumber,vAStreet,vACity,vEmail,vNICNo,vTitle,vCMobile,vCHome,vIsLocal);
	Select PID from patient order by PID desc LIMIT 1 ;
END //
DELIMITER ;

drop procedure UpdatePatient;

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
    vCMobile varchar(10),
    vCHome varchar(10),
    vIsLocal bool

)
BEGIN 


	  IF ( select vCMobile NOT REGEXP '^0{0,1}7[0-9]{8}$') then
		SIGNAL SQLSTATE '45000'
		SET MESSAGE_TEXT = 'Invalid Contact Number';
    END IF;
    
    IF ( select vCHome NOT REGEXP '^0{0,1}[0-9]{9}$') then
		SIGNAL SQLSTATE '45000'
		SET MESSAGE_TEXT = 'Invalid Home Number';
    END IF;
    
    IF ( select vNICNo NOT REGEXP '^([0-9]{9}(V|X|v|x)|[0-9]{12})+$') then
		SIGNAL SQLSTATE '45000'
		SET MESSAGE_TEXT = 'Invalid NIC Number';
    END IF;
     
    IF ( select vEmail NOT REGEXP '^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$') then
		SIGNAL SQLSTATE '45000'
		SET MESSAGE_TEXT = 'Invalid Email Address';
    END IF;
    
    IF ( vFName = '' OR vFName NOT REGEXP '^([\w|\s])+$') then
		SIGNAL SQLSTATE '45000'
		SET MESSAGE_TEXT = 'Invalid First name';
    END IF;
    
    IF ( vLName = '' OR vLName NOT REGEXP '^([\w|\s])+$') then
		SIGNAL SQLSTATE '45000'
		SET MESSAGE_TEXT = 'Invalid Last name';
    END IF;
    
    IF ( vANumber = '' ) then
		SIGNAL SQLSTATE '45000'
		SET MESSAGE_TEXT = 'Address Number cannot be empty';
    END IF;
    IF ( vACity = '') then
		SIGNAL SQLSTATE '45000'
		SET MESSAGE_TEXT = 'Address City cannot be empty';
    END IF;
    IF ( vAStreet = '') then
		SIGNAL SQLSTATE '45000'
		SET MESSAGE_TEXT = 'Address Street cannot be empty';
    END IF;

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
drop procedure SelectAllPatients;
DELIMITER //
create procedure SelectAllPatients()
BEGIN
	select PID, concat(Title,' ',FName,' ',LName) as Name, concat(ANumber,', ',AStreet,', ',ACity) as Address, Email, NICNo, CMobile, CHome from Patient ;
END //
DELIMITER ;
call selectAllPAtients();