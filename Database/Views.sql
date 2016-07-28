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