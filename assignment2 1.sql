use emp273
--1--Select all departments in all locations where the Total Salary of a Department is Greater than twice the Average Salary for the department.
--And max basic for the department is at least thrice the Min basic for the department
CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(100)
);
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    DepartmentID INT,
    EmployeeName VARCHAR(100),
	employeelocation varchar(20),
    BasicSalary DECIMAL(10, 2), 
    FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);

INSERT INTO Departments (DepartmentID, DepartmentName)
VALUES
    (1, 'Human Resources'),
    (2, 'Information Technology'),
    (3, 'Finance'),
    (4, 'Sales'),
    (5, 'Marketing');
drop table employees
INSERT INTO Employees (EmployeeID, DepartmentID, EmployeeName,employeelocation,BasicSalary)
VALUES
    (1, 3, 'Amit Kumar','hyderabad',60000.00),
    (2, 3, 'Priya Sharma','mumbai',55000.00),
    (3, 1, 'Rahul Singh','kolkatta',70000.00),
    (4, 1, 'Ananya Gupta','bengaluru',65000.00),
    (5, 2, 'Neha Verma','hyderabad',58000.00),
    (6, 2, 'Ravi Patel','amritsar',62000.00),
    (7, 4, 'Suresh Menon','patna',55000.00),
    (8, 4, 'Meena Iyer','pune',58000.00),
    (9, 5, 'Vikram Joshi','chennai',72000.00),
    (10, 5, 'Shikha Singh','pune',75000.00),
    (11, 1, 'Sunita Reddy','bengaluru',30000.00),
    (12, 2, 'Rakesh Pandey','pune',20000.00),
    (13, 2, 'Manish Kothari','mumbai',10000.00),
    (14, 3, 'Vijay Chauhan','pune',7000.00),
    (15, 3, 'Kiran Desai','bengaluru',5000.00),
    (16, 4, 'Rohit Jain','mumbai',4000.00),
    (17, 4, 'Sanjana Patel','pune',2000.00),
    (18, 5, 'Aishwarya Nair','mumbai',18000.00),
    (19, 5, 'Praveen Sharma','bengaluru',16000.00);


SELECT d.DepartmentID,d.DepartmentName FROM 
    Departments d
WHERE 
    (SELECT SUM(e1.BasicSalary) 
     FROM Employees e1 
     WHERE e1.DepartmentID = d.DepartmentID group by e1.DepartmentID) > 2 * 
    (SELECT AVG(e2.BasicSalary) 
     FROM Employees e2 
     WHERE e2.DepartmentID = d.DepartmentID group by e2.DepartmentID)
    AND 
    (SELECT MAX(e3.BasicSalary) 
     FROM Employees e3 
     WHERE e3.DepartmentID = d.DepartmentID group by e3.DepartmentID) >= 3 * 
    (SELECT MIN(e4.BasicSalary) 
     FROM Employees e4 
     WHERE e4.DepartmentID = d.DepartmentID group by e4.DepartmentID);

--2--
--As per the companies rule if an employee has put up service of 1 Year 3 Months and 15 days in office, Then She/he would be eligible for a Bonus.
--the Bonus would be Paid on the first of the Next month after which a person has attained eligibility. Find out the eligibility date for all the employees. 
--And also find out the age of the Employee On the date of Payment of the First bonus. Display the Age in Years, Months, and Days.
 Also Display the weekday Name, week of the year, Day of the year and week of the month of the date on which the person has attained the eligibility
CREATE TABLE EmployeeDetails (
    employee_id INT PRIMARY KEY,
    employee_name VARCHAR(100),
    birthdate DATE,
    hire_date DATE,
    centre VARCHAR(50),
    service_type VARCHAR(50),
    service_status VARCHAR(50),
    salary DECIMAL(10, 2),
);
INSERT INTO EmployeeDetails (employee_id, employee_name, birthdate, hire_date, centre, service_type, service_status, salary)
VALUES 
(1, 'Rahul Kumar', '1990-05-15', '2015-03-01', 'Mumbai', 'Full-Time', 'Active', 60000),
(2, 'Priya Sharma', '1992-08-20', '2018-07-15', 'Delhi', 'Part-Time', 'Active', 45000),
(3, 'Amit Singh', '1987-03-10', '2019-01-01', 'Bangalore', 'Full-Time', 'Active', 55000),
(4, 'Deepika Patel', '1995-11-25', '2017-09-05', 'Chennai', 'Contractor', 'Inactive', 50000),
(5, 'Sandeep Verma', '1993-07-02', '2016-06-10', 'Hyderabad', 'Full-Time', 'Active', 65000),
(6, 'Neha Gupta', '1989-12-18', '2020-03-20', 'Kolkata', 'Part-Time', 'Active', 48000),
(7, 'Ravi Kumar', '1991-04-30', '2018-11-15', 'Pune', 'Full-Time', 'Active', 70000),
(8, 'Anjali Mishra', '1994-09-12', '2019-08-01', 'Ahmedabad', 'Contractor', 'Inactive', 52000),
(9, 'Sanjay Singh', '1988-02-05', '2017-05-25', 'Jaipur', 'Full-Time', 'Active', 60000),
(10, 'Meera Reddy', '1996-06-28', '2016-04-15', 'Lucknow', 'Part-Time', 'Active', 45000),
(11, 'Vikram Kapoor', '1990-10-08', '2018-09-10', 'Chandigarh', 'Full-Time', 'Active', 55000),
(12, 'Pooja Sharma', '1985-07-20', '2020-02-01', 'Indore', 'Contractor', 'Inactive', 50000),
(13, 'Ajay Verma', '1993-11-15', '2016-08-12', 'Bhopal', 'Full-Time', 'Active', 65000),
(14, 'Kavita Gupta', '1987-04-12', '2019-12-05', 'Nagpur', 'Part-Time', 'Active', 48000),
(15, 'Rajesh Kumar', '1991-09-25', '2018-10-20', 'Surat', 'Full-Time', 'Active', 70000),
(16, 'Shweta Singh', '1994-01-08', '2019-07-01', 'Visakhapatnam', 'Contractor', 'Inactive', 52000),
(17, 'Alok Sharma', '1986-03-02', '2017-04-15', 'Thane', 'Full-Time', 'Active', 60000),
(18, 'Divya Patel', '1995-05-18', '2016-03-10', 'Gurgaon', 'Part-Time', 'Active', 45000),
(19, 'Manish Kumar', '1990-11-28', '2018-08-10', 'Faridabad', 'Full-Time', 'Active', 55000),
(20, 'Sunita Verma', '1988-06-15', '2020-01-01', 'Noida', 'Contractor', 'Inactive', 50000);

ALTER TABLE EmployeeDetails
ADD EligibilityDate DATE,
UPDATE EmployeeDetails
SET 
    EligibilityDate = DATEADD(DAY, 15, DATEADD(MONTH, 3, DATEADD(YEAR, 1, hire_date))),

alter table employeedetails
add firstbonusdate date

update employeedetails
set
   firstbonusdate=dateadd(month,1,eligibilitydate)


ALTER TABLE EmployeeDetails
ADD Ageatbonus varchar(30)
UPDATE EmployeeDetails
SET 
    ageatbonus=cast(year(firstbonusdate)-year(birthdate) as varchar(2)) + ' years,' + cast(abs(month(firstbonusdate)-month(birthdate)) as varchar(2)) + ' months,' + cast(abs(day(firstbonusdate)-day(birthdate)) as varchar(3)) + ' days'

select hire_date,eligibilitydate,firstbonusdate,ageatbonus,datepart(weekday,firstbonusdate) as Weekday,
datepart(week,firstbonusdate) as Weekofyear,datepart(DayofYear,firstbonusdate) as Dayofbonusyear,floor(DAY(firstbonusdate) / 7)+1 as WeekofMonth
		from employeedetails;

--3--
--Company Has decided to Pay a bonus to all its employees. The criteria is as follows
--1. Service Type 1. Employee Type 1. Minimum service is 10. Minimum service left should be 15 Years. Retirement age will be 60
--Years
--2. Service Type 1. Employee Type 2. Minimum service is 12. Minimum service left should be 14 Years . Retirement age will be 55
--Years
--3. Service Type 1. Employee Type 3. Minimum service is 12. Minimum service left should be 12 Years . Retirement age will be 55
--Years
--3. for Service Type 2,3,4 Minimum Service should Be 15 and Minimum service left should be 20 Years . Retirement age will be 65
--Years
--Write a query to find out the employees who are eligible for the bonus.
CREATE TABLE EmployeeDet(
    employee_id INT PRIMARY KEY,
    employee_name VARCHAR(100),
    birthdate DATE,
    hire_date DATE,
	retirement DATE,
	employee_type int,
	yearsofservice as year(getdate())-year(hire_date),
    centre VARCHAR(50),
    service_type INT,
    service_status VARCHAR(50),
    salary DECIMAL(10, 2),
);
ALTER TABLE EmployeeDet
ADD center_id INT;

INSERT INTO EmployeeDet (employee_id, employee_name, birthdate, hire_date, retirement, employee_type, centre, center_id, service_type, service_status, salary)
VALUES 
(1, 'Rahul Kumar', '1980-05-15', '2000-03-01', '2040-03-01', 1, 'Mumbai', 101, 1, 'Active', 60000),
(2, 'Priya Sharma', '1975-08-20', '2005-07-15', '2030-07-15', 2, 'Delhi', 102, 1, 'Active', 45000),
(3, 'Amit Singh', '1970-03-10', '2005-01-01', '2025-01-01', 3, 'Bangalore', 103, 2, 'Active', 55000),
(4, 'Deepika Patel', '1985-11-25', '2005-09-05', '2045-09-05', 1, 'Chennai', 104, 3, 'Inactive', 50000),
(5, 'Sandeep Verma', '1983-07-02', '2003-06-10', '2043-06-10', 1, 'Hyderabad', 105, 1, 'Active', 65000),
(6, 'Neha Gupta', '1981-12-18', '2005-03-20', '2041-03-20', 2, 'Kolkata', 106, 2, 'Active', 48000),
(7, 'Ravi Kumar', '1985-04-30', '2005-11-15', '2040-11-15', 2, 'Pune', 107, 1, 'Active', 70000),
(8, 'Anjali Mishra', '1987-09-12', '2005-08-01', '2042-08-01', 3, 'Ahmedabad', 108, 3, 'Inactive', 52000),
(9, 'Sanjay Singh', '1978-02-05', '2000-05-25', '2043-05-25', 1, 'Jaipur', 109, 1, 'Active', 60000),
(10, 'Meera Reddy', '1980-06-28', '2000-04-15', '2040-04-15', 2, 'Lucknow', 110, 2, 'Active', 45000),
(11, 'Vikram Kapoor', '1985-10-08', '2005-09-10', '2045-09-10', 3, 'Chandigarh', 111, 4, 'Active', 55000),
(12, 'Pooja Sharma', '1975-07-20', '2005-02-01', '2040-02-01', 1, 'Indore', 112, 4, 'Inactive', 50000),
(13, 'Ajay Verma', '1983-11-15', '2003-08-12', '2043-08-12', 2, 'Bhopal', 113, 1, 'Active', 65000),
(14, 'Kavita Gupta', '1980-04-12', '2005-12-05', '2042-12-05', 3, 'Nagpur', 114, 2, 'Active', 48000),
(15, 'Rajesh Kumar', '1985-09-25', '2005-10-20', '2040-10-20', 2, 'Surat', 115, 3, 'Active', 70000),
(16, 'Shweta Singh', '1987-01-08', '2005-07-01', '2042-07-01', 1, 'Visakhapatnam', 116, 1, 'Inactive', 52000),
(17, 'Alok Sharma', '1981-03-02', '2005-04-15', '2041-04-15', 1, 'Thane', 117, 3, 'Active', 60000),
(18, 'Divya Patel', '1985-05-18', '2005-03-10', '2045-03-10', 3, 'Gurgaon', 118, 4, 'Active', 45000),
(19, 'Manish Kumar', '1979-11-28', '2005-08-10', '2044-08-10', 2, 'Faridabad', 119, 1, 'Active', 55000),
(20, 'Sunita Verma', '1980-06-15', '2000-01-01', '2040-01-01', 3, 'Noida', 120, 2, 'Inactive', 50000);

--considering four conditions creating 4 columns and for each record if any condition pass we write 1 else 0
ALTER TABLE EmployeeDet
ADD case1 AS CASE 
    WHEN service_type = 1 AND employee_type = 1 AND DATEDIFF(YEAR, hire_date, GETDATE()) >= 10 AND 
         (YEAR(retirement) - YEAR(GETDATE())) >= 15 AND 
         (YEAR(retirement) - YEAR(birthdate)) = 60 
    THEN 1 ELSE 0 END;

ALTER TABLE EmployeeDet
ADD case2 AS CASE 
    WHEN service_type = 1 AND employee_type = 2 AND DATEDIFF(YEAR, hire_date, GETDATE()) >= 12 AND 
         (YEAR(retirement) - YEAR(GETDATE())) >= 14 AND 
         (YEAR(retirement) - YEAR(birthdate)) = 55 
    THEN 1 ELSE 0 END;

ALTER TABLE EmployeeDet
ADD case3 AS CASE 
    WHEN service_type = 1 AND employee_type = 3 AND DATEDIFF(YEAR, hire_date, GETDATE()) >= 12 AND 
         (YEAR(retirement) - YEAR(GETDATE())) >= 12 AND 
         (YEAR(retirement) - YEAR(birthdate)) = 55 
    THEN 1 ELSE 0 END;

ALTER TABLE EmployeeDet
ADD case4 AS CASE 
    WHEN service_type IN (2, 3, 4) AND DATEDIFF(YEAR, hire_date, GETDATE()) >= 15 AND 
         (YEAR(retirement) - YEAR(GETDATE())) >= 20 AND 
         (YEAR(retirement) - YEAR(birthdate)) = 65 
    THEN 1 ELSE 0 END;

SELECT 
    employee_id,
    employee_name,
    hire_date,
    retirement,
    case1,
    case2,
    case3,
    case4
FROM 
    EmployeeDet
WHERE
    case1 = 1 OR case2 = 1 OR case3 = 1 OR case4 = 1;



--4--
--write a query to Get Max, Min and Average age of employees, service of employees by service Type , Service Status for each Centre(display in years and Months)
with agecte as
(

select 
    center_id,service_type,service_status,
    MAX(DATEDIFF(YEAR, birthdate, GETDATE())) AS MaxAgeYears,
    MAX(DATEDIFF(MONTH, birthdate, GETDATE()) % 12) AS MaxAgeMonths,
    MIN(DATEDIFF(YEAR, birthdate, GETDATE())) AS MinAgeYears,
    MIN(DATEDIFF(MONTH, birthdate, GETDATE()) % 12) AS MinAgeMonths,
    AVG(DATEDIFF(YEAR, birthdate, GETDATE())) AS AvgAgeYears,
    AVG(DATEDIFF(MONTH, birthdate, GETDATE()) % 12) AS AvgAgeMonths,
    MAX(DATEDIFF(YEAR, hire_date, GETDATE())) AS MaxServiceYears,
    MAX(DATEDIFF(MONTH, hire_date, GETDATE()) % 12) AS MaxServiceMonths,
    MIN(DATEDIFF(YEAR, hire_date, GETDATE())) AS MinServiceYears,
    MIN(DATEDIFF(MONTH, hire_date, GETDATE()) % 12) AS MinServiceMonths,
    AVG(DATEDIFF(YEAR, hire_date, GETDATE())) AS AvgServiceYears,
    AVG(DATEDIFF(MONTH, hire_date, GETDATE()) % 12) AS AvgServiceMonths from employeedet GROUP BY center_id,service_type,service_Status
)
SELECT 
   maxageyears,maxagemonths,minageyears,minagemonths,avgageyears,avgagemonths,maxserviceyears,maxagemonths,minserviceyears,minservicemonths,avgserviceyears,
    avgservicemonths,center_id,service_type,Service_Status
FROM agecte


--5--

CREATE FUNCTION dbo.checkmatch(@InputString VARCHAR(MAX))
RETURNS BIT
AS
BEGIN
    DECLARE @Word NVARCHAR(100)
    DECLARE @Pos INT
    DECLARE @PrevPos INT
    DECLARE @Length INT
    SET @Pos = 1
    SET @PrevPos = 1
    SET @Length = LEN(@InputString)
    WHILE @Pos <= @Length
    BEGIN
        SET @Pos = CHARINDEX(' ', @InputString + ' ', @PrevPos)
        SET @Word = SUBSTRING(@InputString, @PrevPos, @Pos - @PrevPos)
        IF LEFT(@Word, 1) = RIGHT(@Word, 1) AND LEN(@Word) > 1
        BEGIN
            RETURN 1 
        END
        SET @PrevPos = @Pos + 1
    END
    RETURN 0
END
GO

SELECT *
FROM Employees
WHERE dbo.checkmatch(EmployeeName) = 1;


 
 