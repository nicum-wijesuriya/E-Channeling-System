create table Speciality
(
	SID int Primary Key auto_increment,
    Name varchar(60)
);

DELIMITER //
create procedure AddSpeciality (
	vName varchar(60)
)
BEGIN
	insert into Speciality (Name) values (vName);
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


Insert into speciality(Name) values ('Cardiac Electrophysiologists');
Insert into speciality(Name) values ('Cardiologists');
Insert into speciality(Name) values ('Cardiothoracic Surgeons ');
Insert into speciality(Name) values ('Chest Physicians ');
Insert into speciality(Name) values ('Chest Specialists ');
Insert into speciality(Name) values ('Dental Surgeons ');
Insert into speciality(Name) values ('Dermatologists ');
Insert into speciality(Name) values ('Dermatology & Hair Specialists ');
Insert into speciality(Name) values ('Diabetes & Endocrinology Physician ');
Insert into speciality(Name) values ('Diabetologists & Endocrinologists ');
Insert into speciality(Name) values ('Dietician & Nutritionists ');
Insert into speciality(Name) values ('Dieticians ');
Insert into speciality(Name) values ('ENT Surgeons ');
Insert into speciality(Name) values ('Eye Surgeon ');
Insert into speciality(Name) values ('Gastroenterological Surgeon ');
Insert into speciality(Name) values ('Gastroenterologists (Medical) ');
Insert into speciality(Name) values ('Gastrointestinal Surgeons ');
Insert into speciality(Name) values ('Gynaecologists ');
Insert into speciality(Name) values ('Haematologists ');
Insert into speciality(Name) values ('Immunologists ');
Insert into speciality(Name) values ('Interventional Cardiologists ');
Insert into speciality(Name) values ('Medical Microbiologists ');
Insert into speciality(Name) values ('Nephrologist & Physicians ');
Insert into speciality(Name) values ('Nephrologists ');
Insert into speciality(Name) values ('Neuro Physicians ');
Insert into speciality(Name) values ('Neurosurgeons ');
Insert into speciality(Name) values ('Obstetrician Gynaecologist & Infertility Specialists ');
Insert into speciality(Name) values ('Oncological Surgeons ');
Insert into speciality(Name) values ('Oncologists (Cancer Specialists) ');
Insert into speciality(Name) values ('Oral Maxillofacial Surgeons ');
Insert into speciality(Name) values ('Orthodontists ');
Insert into speciality(Name) values ('Orthopaedic Surgeons ');
Insert into speciality(Name) values ('Paediatric  Cardiologists ');
Insert into speciality(Name) values ('Paediatric Cardiothoracic Surgeons ');
Insert into speciality(Name) values ('Paediatric Neurologists ');
Insert into speciality(Name) values ('Paediatric Orthopaedic Surgeons ');
Insert into speciality(Name) values ('Paediatric Surgeons ');
Insert into speciality(Name) values ('Paediatricians ');
Insert into speciality(Name) values ('Parasitologists ');
Insert into speciality(Name) values ('Physician & Endocrinologist/Diabetologist ');
Insert into speciality(Name) values ('Physician and Immunologist ');
Insert into speciality(Name) values ('Physicians ');
Insert into speciality(Name) values ('Physiotherapists ');
Insert into speciality(Name) values ('Plastic Surgeons ');
Insert into speciality(Name) values ('Psychiatrists ');
Insert into speciality(Name) values ('Psychologists ');
Insert into speciality(Name) values ('Rheumatologists ');
Insert into speciality(Name) values ('Sexual Medicine ');
Insert into speciality(Name) values ('Speech & Language Therapists ');
Insert into speciality(Name) values ('Speech Therapists ');
Insert into speciality(Name) values ('Speech, Language Pathologist & Audiologists ');
Insert into speciality(Name) values ('Speech, Pathologist & Therapists ');
Insert into speciality(Name) values ('Sport Medicine ');
Insert into speciality(Name) values ('STD Specialists ');
Insert into speciality(Name) values ('Surgeons ');
Insert into speciality(Name) values ('Thoracic Surgeon ');
Insert into speciality(Name) values ('Transplant & Genitourinary Surgeons ');
Insert into speciality(Name) values ('Urologists ');
Insert into speciality(Name) values ('Vaccinologist ');
Insert into speciality(Name) values ('Vascular Surgeons ');
