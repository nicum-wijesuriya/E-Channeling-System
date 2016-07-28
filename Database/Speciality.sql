create table Speciality
(
	SID int Primary Key auto_increment,
    Name varchar(60)
);

drop procedure AddSpeciality;

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



truncate table Speciality;

Insert into speciality(Name) values ('Audiologist');
Insert into speciality(Name) values ('Cardiac Electrophysiologist');
Insert into speciality(Name) values ('Cardiologist');
Insert into speciality(Name) values ('Cardiothoracic Surgeon ');
Insert into speciality(Name) values ('Chest Physician ');
Insert into speciality(Name) values ('Chest Specialist ');
Insert into speciality(Name) values ('Dental Surgeon ');
Insert into speciality(Name) values ('Dermatologist ');
Insert into speciality(Name) values ('Dermatology & Hair Specialist ');
Insert into speciality(Name) values ('Diabetes & Endocrinology Physician ');
Insert into speciality(Name) values ('Diabetologist');
Insert into speciality(Name) values ('Dietician & Nutritionist');
Insert into speciality(Name) values ('Dietician');
Insert into speciality(Name) values ('Endocrinologist ');
Insert into speciality(Name) values ('ENT Surgeon ');
Insert into speciality(Name) values ('Eye Surgeon ');
Insert into speciality(Name) values ('Gastroenterological Surgeon');
Insert into speciality(Name) values ('Gastroenterologist (Medical)');
Insert into speciality(Name) values ('Gastrointestinal Surgeon ');
Insert into speciality(Name) values ('Gynaecologist');
Insert into speciality(Name) values ('Haematologist');
Insert into speciality(Name) values ('Immunologist');
Insert into speciality(Name) values ('Infertility Specialist');
Insert into speciality(Name) values ('Interventional Cardiologist ');
Insert into speciality(Name) values ('Medical Microbiologist');
Insert into speciality(Name) values ('Nephrologist');
Insert into speciality(Name) values ('Neuro Physician');
Insert into speciality(Name) values ('Neurosurgeon ');
Insert into speciality(Name) values ('Obstetrician Gynaecologist');
Insert into speciality(Name) values ('Oncological Surgeon');
Insert into speciality(Name) values ('Oncologist (Cancer Specialist)');
Insert into speciality(Name) values ('Oral Maxillofacial Surgeon ');
Insert into speciality(Name) values ('Orthodontist');
Insert into speciality(Name) values ('Orthopaedic Surgeon');
Insert into speciality(Name) values ('Paediatric  Cardiologist');
Insert into speciality(Name) values ('Paediatric Cardiothoracic Surgeon');
Insert into speciality(Name) values ('Paediatric Neurologist');
Insert into speciality(Name) values ('Paediatric Orthopaedic Surgeon ');
Insert into speciality(Name) values ('Paediatric Surgeon ');
Insert into speciality(Name) values ('Paediatrician ');
Insert into speciality(Name) values ('Parasitologist ');
Insert into speciality(Name) values ('Pathologist');
Insert into speciality(Name) values ('Physician');
Insert into speciality(Name) values ('Physiotherapist');
Insert into speciality(Name) values ('Plastic Surgeon');
Insert into speciality(Name) values ('Psychiatrist');
Insert into speciality(Name) values ('Psychologist');
Insert into speciality(Name) values ('Rheumatologist');
Insert into speciality(Name) values ('Sexual Medicine');
Insert into speciality(Name) values ('Speech & Language Therapist');
Insert into speciality(Name) values ('Speech Therapist');
Insert into speciality(Name) values ('Speech, Language Pathologist');
Insert into speciality(Name) values ('Sport Medicine');
Insert into speciality(Name) values ('STD Specialist');
Insert into speciality(Name) values ('Surgeon');
Insert into speciality(Name) values ('Thoracic Surgeon');
Insert into speciality(Name) values ('Transplant & Genitourinary Surgeon');
Insert into speciality(Name) values ('Urologist');
Insert into speciality(Name) values ('Vaccinologist');
Insert into speciality(Name) values ('Vascular Surgeon');
