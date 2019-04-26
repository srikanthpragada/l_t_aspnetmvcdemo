create table Courses
(
  CourseID  int identity primary key,
  CourseName varchar(20) not null,
  CourseDesc varchar(100)
)

create table Students
(
  StudentID int identity primary key,
  Fullname  varchar(20) not null,
  Email     varchar(50),
  Course    int  references courses on delete cascade
)

insert into courses values('Oracle','Oracle Database 12c')
insert into courses values('Python','Python Language and Django Framework')
insert into courses values('Ds','Data Science with Python')
insert into courses values('Java','Java Language and Library')


insert into Students values('Scott Guthrie','scott@gmail.com',2)
insert into Students values('Stephen Walther','stephen@gmail.com',2)
insert into Students values('Joe Stagner','joe@hotmail.com',3)
insert into Students values('Andy Booch','andy@gmail.com',4)
insert into Students values('Jessy Liberty','jessy@gmail.com',1)
insert into Students values('Dan Appleman','dan@gmail.com',4)
insert into Students values('Scott Allen','allen@gmail.com',2)