-------------------------------------------CUSTOMER-------------------------------------------------------
USE Testdb;
CREATE TABLE [CUSTOMER]
( CustomerId int IDENTITY(1,1) PRIMARY KEY,
CustomerNumber int NOT NULL UNIQUE CHECK (CustomerNumber>0),
LastName varchar (50) NOT NULL,
FirstName varchar(50) NOT NULL,
Country varchar (20) DEFAULT 'Norway',
AreaCode int NULL,
Address varchar (50) NULL,
Phone varchar(50) NULL, 
)

INSERT INTO [CUSTOMER] (CustomerNumber, LastName, FirstName, Country, AreaCode, Address, Phone)
VALUES
    (329, 'Smith', 'John', 'USA', 5467, '123 Main St', '983234987'),
    (567, 'Cook', 'Tim', 'Canada', 4098, '456 Elm St', '9832349877'),
	(765, 'John', 'Cook', 'UK', 5647, '567 El St', '9856249877');

--SELECTING SPECIFIC COLUMNS 
SELECT CustomerId, FirstName From CUSTOMER;

SELECT * FROM CUSTOMER WHERE CustomerId>1;

UPDATE CUSTOMER
SET AreaCode=9876, Address='UK', Phone=12239887765
WHERE CustomerId=2

DELETE FROM CUSTOMER
WHERE CustomerId=1

SELECT * FROM CUSTOMER WHERE CustomerNumber='2'

SELECT * FROM CUSTOMER WHERE AreaCode<5000

SELECT * FROM CUSTOMER WHERE AreaCode>5000

SELECT * FROM CUSTOMER WHERE LastName like 'S%'

SELECT * FROM CUSTOMER WHERE LastName Not like '%z%' 

SELECT * FROM CUSTOMER WHERE FirstName like 'T%'

SELECT * FROM CUSTOMER WHERE FirstName Not like 'J%'
 
SELECT * FROM CUSTOMER WHERE AreaCode>5000

SELECT * FROM CUSTOMER
WHERE CustomerId IN (1,2)

SELECT * FROM CUSTOMER
WHERE CustomerId
BETWEEN 1 AND 3

SELECT * FROM CUSTOMER WHERE CustomerNumber LIKE '[40]%'

SELECT * FROM CUSTOMER WHERE LastName='Smith' and FirstName='John'

SELECT * FROM CUSTOMER WHERE LastName='Smith' and (FirstName='John' or FirstName='Tim')

DECLARE @CustomerNumber INT
IF @CustomerNumber > 500
PRINT 'The Customer Number is larger than 500'
ELSE
PRINT 'The Customer Number is not larger than 500'

WHILE (SELECT AreaCode FROM CUSTOMER WHERE CustomerId=1) = 5467
BEGIN
UPDATE CUSTOMER SET AreaCode = AreaCode + 1
END

SELECT * FROM CUSTOMER 
select COUNT(*) as NumbersofCustomers from CUSTOMER 
select FirstName, MAX(AreaCode) from CUSTOMER group by FirstName

-- Declare variables and use a cursor to update phone numbers.
SELECT * FROM CUSTOMER 
DECLARE
@CustomerId int, 
@phone varchar(40) 
DECLARE db_cursor CURSOR 
FOR SELECT CustomerId from CUSTOMER 
OPEN db_cursor 
FETCH NEXT FROM db_cursor INTO @CustomerId 
WHILE @@FETCH_STATUS = 0 
BEGIN 

SELECT @phone=Phone FROM CUSTOMER WHERE CustomerId=@CustomerId

IF LEN(@phone) < 8
update CUSTOMER SET Phone='Phone number is not valid' WHERE
CustomerId=@CustomerId
FETCH NEXT FROM db_cursor INTO @CustomerId 
END 
CLOSE db_cursor 
DEALLOCATE db_cursor

-----------------------------------------------------------SCHOOL-------------------------------------

USE TestDb01;

CREATE TABLE SCHOOL (
    SchoolId INT PRIMARY KEY,
    SchoolName NVARCHAR(50),
    Description NVARCHAR(100),
    Address NVARCHAR(100),
    Phone NVARCHAR(20),
    PostCode NVARCHAR(10),
    PostAddress NVARCHAR(100)
);

CREATE TABLE CLASS (
    ClassId INT PRIMARY KEY,
    SchoolId INT,
    ClassName NVARCHAR(50),
    Description NVARCHAR(100),
    FOREIGN KEY (SchoolId) REFERENCES SCHOOL(SchoolId)
);

SELECT * From SCHOOL;

INSERT INTO SCHOOL (SchoolId, SchoolName, Description, Address, Phone, PostCode, PostAddress)
VALUES (101, 'Sample School', 'A sample school description', '123 School', '123456789', '12345', 'Chennai');

INSERT INTO SCHOOL (SchoolId, SchoolName, Description, Address, Phone, PostCode, PostAddress)
VALUES (102, 'School Sample', 'A sample school description', '321 School', '765432345', '16548', 'Chennai');

INSERT INTO SCHOOL (SchoolId, SchoolName, Description, Address, Phone, PostCode, PostAddress)
VALUES (103, 'New Horizon High School', 'Providing quality education', '456 Education Ave', '987654321', '54321', 'New York');

INSERT INTO SCHOOL (SchoolId, SchoolName, Description, Address, Phone, PostCode, PostAddress)
VALUES (104, 'Greenfield Elementary', 'A nurturing learning environment', '789 Park Street', '1239876543', '98765', 'Los Angeles');

INSERT INTO SCHOOL (SchoolId, SchoolName, Description, Address, Phone, PostCode, PostAddress)
VALUES (105, 'Bright Minds Academy', 'Where knowledge shines', '567 Learning Lane', '9876541230', '87654', 'Chicago');

INSERT INTO SCHOOL (SchoolId, SchoolName, Description, Address, Phone, PostCode, PostAddress)
VALUES (106, 'Hillside Middle School', 'Empowering young minds', '890 School Road', '4567890123', '76543', 'Houston');

INSERT INTO SCHOOL (SchoolId, SchoolName, Description, Address, Phone, PostCode, PostAddress)
VALUES (107, 'Sunset High School', 'Preparing students for the future', '123 Sunset Blvd', '3219876543', '34567', 'San Francisco');

INSERT INTO CLASS (ClassId, SchoolId, ClassName, Description)
VALUES (1, 101, 'Class A', 'Introduction to Science');

INSERT INTO CLASS (ClassId, SchoolId, ClassName, Description)
VALUES (2, 101, 'Class B', 'Mathematics Basics');

INSERT INTO CLASS (ClassId, SchoolId, ClassName, Description)
VALUES (3, 102, 'Class X', 'Advanced History');

INSERT INTO CLASS (ClassId, SchoolId, ClassName, Description)
VALUES (4, 103, 'Grade 5', 'English Literature');

INSERT INTO CLASS (ClassId, SchoolId, ClassName, Description)
VALUES (5, 104, 'Grade 3', 'Art and Creativity');


SELECT
SCHOOL.SchoolName,
CLASS.ClassName
from
SCHOOL 
INNER JOIN CLASS ON SCHOOL.SchoolId = CLASS.SchoolId

CREATE VIEW SchoolView
AS
SELECT
SCHOOL.SchoolName,
CLASS.ClassName
FROM
SCHOOL 
INNER JOIN CLASS ON SCHOOL.SchoolId = CLASS.SchoolId

select * from SchoolView

SELECT AVG(SchoolId) FROM SCHOOL

SELECT COUNT(SchoolId) FROM SCHOOL

SELECT COUNT(*) FROM SCHOOL

CREATE PROCEDURE GetAllSchoolClasses
AS
select
SCHOOL.SchoolName,
CLASS.ClassName
from
SCHOOL
inner join CLASS on SCHOOL.SchoolId = CLASS.SchoolId
order by SchoolName, ClassName

execute GetAllSchoolClasses

CREATE PROCEDURE GetSpecificSchoolClasses
@SchoolName varchar(50)
AS
select
SCHOOL.SchoolName,
CLASS.ClassName
from
SCHOOL
inner join CLASS on SCHOOL.SchoolId = CLASS.SchoolId
where SchoolName=@SchoolName
order by ClassName

execute GetSpecificSchoolClasses 'Greenfield Elementary'

-------------------------------------------------------------------------------------------------------------------------------



