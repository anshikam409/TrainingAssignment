create database Codebased
use Codebased

--I
--a. Create a table called Code_Employee(empno int primary key,empname varchar(35), (is a required field),empsal numeric(10,2) - (check empsal >=25000)
--emptype char(1) ) (either 'F' for fulltime or 'P' part time) (Empty Table)
CREATE TABLE Code_Employees (
    empno int PRIMARY KEY,
    empname varchar(35),
    empsal decimal(10,2) NOT NULL CHECK (empsal > 0),
    emptype char(1) CHECK (emptype IN ('F', 'P'))
);

CREATE PROCEDURE AddEmployees
    @empno int,
    @empname varchar(35),
    @empsal decimal(10,2),
    @emptype char(1)
AS
BEGIN
    INSERT INTO Code_Employees(empno, empname, empsal, emptype)
    VALUES (@empno, @empname, @empsal, @emptype)
END;

--select* from Employee

EXEC AddEmployees 7369,'manya',8000.00,'F'
EXEC AddEmployees 7499,'anshika',5001.00,'P'
EXEC AddEmployees 7521,'prachi',6000.00,'F'
EXEC AddEmployees 7566,'ayushi',2975.00,'P'

--II. Write a Cursor program, that retrieves all the employees and updates salary for all employees of Department 10(Accounting) by 15%

--creating table Employee
create table employees(
empno numeric(4) primary key,ename varchar(20),job varchar(30),mgr_id int,hiredate date, salary int,comm int,deptno int
)

--inserting values in table employee
insert into employees values(7369,'SMITH','CLERK',7902,'17-DEC-80',800,null,20)
insert into employees values(7499,'ALLEN','SALESMAN',7698,'20-FEB-81',1600,300,30)
insert into employees values(7521,'WARD','SALESMAN',7698,'22-FEB-81',1250,500,30)
insert into employees values(7566,'JONES','MANAGER',7839,'02-APR-81',2975,null,20)
insert into employees values(7654,'MARTIN','SALESMAN',7698,'28-SEP-81',1250,1400,30)
insert into employees values(7698,'BLAKE','MANAGER',7839,'01-MAY-81',2850,null,30)
insert into employees values(7782,'CLARK','MANAGER',7839,'09-JUN-81',2450,null,10)
insert into employees values(7788,'SCOTT','ANALYST',7566,'19-APR-87',3000,null,20)
insert into employees values(7839,'KING','PRESIDENT',null,'17-NOV-81',5000,null,10)
insert into employees values(7844,'TURNER','SALESMAN',7698,'08-SEP-81',1500,0,30)
insert into employees values(7876,'ADAMS','CLERK',7788,'23-MAY-87',1100,null,20)
insert into employees values(7900,'JAMES','CLERK',7698,'03-DEC-81',950,null,30)
insert into employees values(7902,'FORD','ANALYST',7566,'03-DEC-81',3000,null,20)
insert into employees values(7934,'MILLER','CLERK',7782,'23-JAN-82',1300,null,10)

CREATE PROCEDURE UpdateSalaryForAccountingEmployees
AS
BEGIN
    DECLARE @empno INT;
    DECLARE @empsal INT;
    DECLARE @newSalary INT;
    DECLARE accountingEmployees CURSOR FOR
        SELECT empno, salary
        FROM employees
        WHERE deptno = 10;
    OPEN accountingEmployees;
    FETCH NEXT FROM accountingEmployees INTO @empno, @empsal;
    WHILE @@FETCH_STATUS = 0
    BEGIN
        SET @newSalary = @empsal * 0.15;
        UPDATE employees
        SET salary = @newSalary
        WHERE empno = @empno;
        FETCH NEXT FROM accountingEmployees INTO @empno, @empsal;
    END
    CLOSE accountingEmployees;
    DEALLOCATE accountingEmployees;
END;

EXEC UpdateSalaryForAccountingEmployees;

SELECT * FROM employees WHERE deptno = 10;