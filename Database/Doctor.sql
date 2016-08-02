use AMC;

create table Doctor
(
	DID int Primary Key auto_increment,
	Title varchar(11),
	FName varchar(15) not null,
    LName varchar(30) not null,
    Contact int(10),
	Email varchar(50),
	Fee double(8,2),
    isDeleted bool default false
);

alter table Doctor Modify Title varchar(11);

drop procedure AddDoctor;
DELIMITER //
create procedure AddDoctor (
	vTitle varchar(11),
	vFName varchar(15),
    vLName varchar(30),
    vContact varchar(10),
	vEmail varchar(50),
	vFee varchar(9)
)

Begin
	
    IF ( select vTitle NOT REGEXP '^(Prof.|Dr.)|(Prof.|Dr.)\((Mrs.|Ms.)\)$') then
		SIGNAL SQLSTATE '45000'
		SET MESSAGE_TEXT = 'Invalid Title';
    END IF;       
    
    IF ( select vFname NOT REGEXP '^[a-zA-Z]+[\ a-zA-Z]*$') then
		SIGNAL SQLSTATE '45000'
		SET MESSAGE_TEXT = 'Please fill First Name';
    END IF;    
        
	IF ( select vLname NOT REGEXP '^[a-zA-Z]+[\ a-zA-Z]*$') then
		SIGNAL SQLSTATE '45000'
		SET MESSAGE_TEXT = 'Please fill Last Name';
    END IF;    
    
    IF ( select vContact NOT REGEXP '^0{0,1}7[0-9]{8}$') then
		SIGNAL SQLSTATE '45000'
		SET MESSAGE_TEXT = 'Invalid Contact Number';
    END IF;
    
    IF ( select vContact NOT REGEXP '^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)') then
		SIGNAL SQLSTATE '45000'
		SET MESSAGE_TEXT = 'Invalid email address';
    END IF;
    
    IF(select vFee NOT REGEXP '^([0-9]+)$|^([0-9]+(.00)+)$') THEN 
		SIGNAL SQLSTATE '45000' 
		SET MESSAGE_TEXT = 'Invalid Fee';
	END IF;
      
    insert into Doctor (Title, FName, LName, Contact, Email, Fee)
    values (vTitle, vFName, vLName, vContact, vEmail, vFee);
    select DID from Doctor order by DID desc LIMIT 1;

END //
DELIMITER ;

select * from Doctor;

call AddDoctor ('Prof.(Mrs.)', 'Kamal', 'Perera', 1234597, 'kalad;jm', 100000000000000);

drop procedure UpdateDoctor;

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

drop procedure AvailableDoctors;

DELIMITER //
create procedure AvailableDoctors()
BEGIN
	Select distinct(DID), concat(Title,FName,' ',LName) from AvailableDoctors;
END //
DELIMITER ;
drop procedure AvailableDoctorsForSpecialization;
DELIMITER //
create procedure AvailableDoctorsForSpecialization(vSID int)
BEGIN
	Select distinct(DID), concat(Title,'', FName,' ', LName) from AvailableDoctors where SID = vSID;
END //
DELIMITER ;

drop procedure AllDoctors;
DELIMITER //
create procedure AllDoctors()
BEGIN
	Select distinct(DID), concat(Title,FName,' ',LName), Contact, Email, Fee from Doctor;
END //
DELIMITER ;
call AvailableDoctorsForSpecialization(2);
select * from Doc_Spec;

select * from speciality;