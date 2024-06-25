--1--1. Write a script to extracts all the numerics from Alphanumeric String
use vivek_273;
--method1
DECLARE @num NVARCHAR(25);
SET @num= 'VIV123EK53##522';

WHILE PATINDEX('%[^0-9]%', @num) != 0
BEGIN
    SET @num = REPLACE(@num, SUBSTRING(@num, PATINDEX('%[^0-9]%', @num), 1), '');
END

SELECT @num as onlynum;

--method2
DECLARE @num1 VARCHAR(25);
SET @num1='VIV123EK53##522';
DECLARE @len int=len(@num1);
DECLARE @Counter INT 
DECLARE @news varchar(25)=''
SET @Counter=1
WHILE ( @Counter <= @len)
BEGIN
    DECLARE @char char = SUBSTRING(@num1, @counter, 1);
    if isnumeric(@char)=1
	begin
	   set @news=@news+@char
	end
    SET @Counter=@Counter+1
END
select @news

--2--Write a script to calculate age based on the Input DOB

BEGIN TRY
    DECLARE @date DATE = '2002-13-02';
    SELECT DATEDIFF(YY, @date, GETDATE()) AS Age;
END TRY
BEGIN CATCH
    DECLARE @ErrorMessage NVARCHAR(4000);
    SELECT 
        @ErrorMessage = ERROR_MESSAGE();

    PRINT 'Entered date format is wrong please check the date: ';
END CATCH;


--3--Create a column in a table and that should throw an error when we do SELECT * or SELECT of that column. If we select other columns then we should see results
alter table product add discount as CAST('1' AS INT)

DECLARE @col varchar(20)
set @col='discount'
select * from product where 



--4--
create table cal(
[date] date,
[dayofyear] as DATEPART(DAYOFYEAR, [date]),
[week] as DATEPART(WEEK, [date]),
[dayofweek] as DATEPART(WEEKDAY,[date]),
[month] as DATEPART(MONTH, [date]),
[dateofmonth] as DATEPART(DAY, [date])
);
BEGIN TRY
DECLARE @year INT = 2018
DECLARE @date DATE = CONCAT(@year, '/13/01')
END TRY
BEGIN CATCH
    PRINT 'Entered date format is wrong please check the date: ';
END CATCH;
 
WHILE (YEAR(@date)=@year)
BEGIN
	INSERT INTO cal VALUES (@date)
	SET @date = DATEADD(d, 1, @date)
	if month(@date)=12 AND day(@date)=31
	begin
	    set @year=@year+1
	end
END
select * from cal;
TRUNCATE TABLE cal

--5--Display Emp and Manager Hierarchies based on the input till the topmost hierarchy. (Input would be empid)
--Output: Empid, empname, managername, heirarchylevel
 create table employ(empid int,empname varchar(30),managerid int);
 insert into employ values(121,'ravi',NULL),(122,'ram',121),(123,'hari',122),(124,'giri',122);
 select * from employ;
 truncate table employ;

 --method1 without cte 
DECLARE @hierarchylevel int
set @hierarchylevel=1
SELECT G.empid,G.empname,p.empname as managername,G.hierarchy as hierarchy
from 
(select empid,empname,managerid,@hierarchylevel as hierarchy from employ where empid=122
union all
select e.empid, e.empname, e.managerid,@hierarchylevel+1 from employ e
    INNER JOIN employ ee ON e.EmpID =ee.managerid and ee.empid=122) AS G 
	left join employ p on G.managerid=p.empid;

--method2 with cte
with hier as
(
  select empid,empname,managerid,1 as hierarchylevel from employ where empid=122
  union all
  select e.empid, e.empname, e.managerid,h.hierarchylevel+1 from employ e
    INNER JOIN hier h ON e.EmpID =h.managerid
)
SELECT h.empid,h.empname,e.empname as managername,h.hierarchylevel
from hier h
LEFT JOIN employ e ON h.managerid = e.empid;



