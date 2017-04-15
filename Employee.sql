CREATE TABLE Employee
(
	EmployeeId INT NOT NULL IDENTITY (1,1) PRIMARY KEY,
	Name varchar(30) NOT NULL,
	DepartamentId int NOT NULL,
	Address varchar(50)

)

CREATE TABLE Departament
(
	DepartamentId INT NOT NULL PRIMARY KEY,
	DepartamentName varchar(30) NOT NULL
	CONSTRAINT FK_DEPT FOREIGN KEY (DepartamentId) REFERENCES Employee
)

INSERT INTO Employee VALUES ('Jack',1,'Backer Street Nº1245');
INSERT INTO Employee VALUES ('Kathyerine',1,'S/N Street Nº1245');
INSERT INTO Employee VALUES ('Luigi',2,'Brasil Street Nº1245');
INSERT INTO Employee VALUES ('Naoko',2,'Japan Street Nº1245');

INSERT INTO Departament VALUES (1,'Development');
INSERT INTO Departament VALUES (2,'Technology');

select Name,DepartamentName from Employee t1 inner join Departament t2 on t1.DepartamentId = t2.DepartamentId
where t1.DepartamentId = 1;
