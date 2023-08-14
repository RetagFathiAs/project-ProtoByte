create table Patientmore
(
pid bigint,
Symptoms varchar(150),
Diagmosis varchar(150),
Medicines varchar(150),
Ward varchar(15),
Ward_Type varchar(20),
)

 select * from AddPatient;
 select * from AddPatient inner join Patientmore on AddPatient.pid = Patientmore.pid