create database Assignment4

use assignment4

--Question 1.	Write a T-SQL Program to find the factorial of a given number.

CREATE OR ALTER FUNCTION CalculateFactorial (@n INT)
RETURNS INT
AS
BEGIN
    DECLARE @factorial INT = 1;
    WHILE @n >= 1
    BEGIN
        SET @factorial = @factorial * @n;
        SET @n = @n - 1;
    END
    RETURN @factorial;
END

--Output of Question 1

SELECT dbo.CalculateFactorial(3) AS FactorialResult

--Question 2. Create a stored procedure to generate multiplication tables up to a given number.

CREATE OR ALTER PROCEDURE GenerateMultiplicationTables (@number INT)
AS
BEGIN
    DECLARE @n INT = 1, @table INT;
    WHILE @n <= 10
    BEGIN
        SET @table = @number * @n;
        PRINT CAST(@number AS VARCHAR(10)) + ' * ' + CAST(@n AS VARCHAR(10)) + ' = ' + CAST(@table AS VARCHAR(20));
        SET @n = @n + 1;
    END
END

--Output for Question 2

EXEC GenerateMultiplicationTables 3

--Question 3.  Create a trigger to restrict data manipulation on EMP table during General holidays.
--Display the error message like “Due to Independence day you cannot manipulate data” or "Due To Diwali", you cannot manupulate" etc
--Note: Create holiday table as (holiday_date,Holiday_name) store at least 4 holiday details. try to match and stop manipulation

--creating table Employee
create table employee(
empno numeric(4) primary key,ename varchar(20),job varchar(30),mgr_id int,hiredate date, salary int,comm int,deptno int
)

--inserting values in table employee
insert into employee values(7369,'SMITH','CLERK',7902,'17-DEC-80',800,null,20)
insert into employee values(7499,'ALLEN','SALESMAN',7698,'20-FEB-81',1600,300,30)
insert into employee values(7521,'WARD','SALESMAN',7698,'22-FEB-81',1250,500,30)
insert into employee values(7566,'JONES','MANAGER',7839,'02-APR-81',2975,null,20)
insert into employee values(7654,'MARTIN','SALESMAN',7698,'28-SEP-81',1250,1400,30)
insert into employee values(7698,'BLAKE','MANAGER',7839,'01-MAY-81',2850,null,30)
insert into employee values(7782,'CLARK','MANAGER',7839,'09-JUN-81',2450,null,10)
insert into employee values(7788,'SCOTT','ANALYST',7566,'19-APR-87',3000,null,20)
insert into employee values(7839,'KING','PRESIDENT',null,'17-NOV-81',5000,null,10)
insert into employee values(7844,'TURNER','SALESMAN',7698,'08-SEP-81',1500,0,30)
insert into employee values(7876,'ADAMS','CLERK',7788,'23-MAY-87',1100,null,20)
insert into employee values(7900,'JAMES','CLERK',7698,'03-DEC-81',950,null,30)
insert into employee values(7902,'FORD','ANALYST',7566,'03-DEC-81',3000,null,20)
insert into employee values(7934,'MILLER','CLERK',7782,'23-JAN-82',1300,null,10)

select* from employee

--creating table holiday
create table Holidays
(holiday_date Date Primary Key, holiday_name nvarchar(max));

--inserting values in table holidays

INSERT INTO HOLIDAYs values
('2024-01-26','Republic Day'),
('2023-08-15','Independence Day'),
('2023-11-13','Diwali'),
('2023-12-25','Christmas'),
('2023-10-16','Garba Night Day2')

--updating values in table Holidays

update Holidays
set holiday_name='Gandhi Jayanti'
where holiday_date='2023-10-02'


CREATE TRIGGER RestrictDataholiday
ON employee
FOR INSERT, UPDATE, DELETE 
AS 
BEGIN     
DECLARE @Holiday_name VARCHAR(50), @holiday_date DATE
SET @holiday_date = CONVERT(DATE, GETDATE())
SELECT @Holiday_name = Holiday_name     
FROM Holidays     
WHERE holiday_date = @holiday_date 
IF @holiday_name IS NOT NULL     
BEGIN         
ROLLBACK TRANSACTION        
RAISERROR('Due to %s, you cannot manipulate data', 16, 1, @holiday_name)     
END 
END

select * from employee
 
insert into employee values(7355,'Anshika', 'SDE', 10000,'2023-10-03',5678,null,20)