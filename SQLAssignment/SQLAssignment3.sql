create database assignment3
use assignment3

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

--selecting table employee
select* from employee

--creating table department
create table Department(
deptno numeric(4) primary key,dname varchar(20),Loc varchar(30)
)

--inserting values in table department
insert into department values(10,'ACCOUNTING','NEW YORK') 
insert into department values(20,'RESEARCH','DALLAS') 
insert into department values(30,'SALES','CHICAGO') 
insert into department values(40,'OPERATIONS','BOSTON') 

--selecting table department
select* from department

--Queries

--Query 1.Retrieve a list of MANAGERS. 
select* from employee where job='Manager'

--Query 2. Find out the names and salaries of all employees earning more than 1000 per month. 
select ename ,salary from employee where salary>1000

--Query 3. Display the names and salaries of all employees except JAMES. 
select ename,salary from employee where ename <>'james'

--Query 4. Find out the details of employees whose names begin with ‘S’. 
select* from employee where ename like 'S%'

--Query 5. Find out the names of all employees that have ‘A’ anywhere in their name. 
select ename from employee where ename like '%a%'

--Query 6. Find out the names of all employees that have ‘L’ as their third character in their name. 
select ename from employee where substring(ename,3,1)='l'

--Query 7. Compute daily salary of JONES. 
select ename,salary/30 as daily_salary from employee where ename='jones' 

--Query 8. Calculate the total monthly salary of all employees. 
select sum(salary) as total_monthly_salary from employee

--Query 9. Print the average annual salary . 
select avg(salary*12) as avg_annual_salary from employee

--Query 10. Select the name, job, salary, department number of all employees except SALESMAN from department number 30. 
select ename,job,salary,deptno from employee where job<>'salesman' and deptno=30

--Query 11. List unique departments of the EMP table. 
select distinct deptno from employee

--Query 12. List the name and salary of employees who earn more than 1500 and are in department 10 or 30. Label the columns Employee and Monthly Salary respectively.
select ename as employee,salary as monthly_salary from employee where salary>1500 and (deptno=10 or deptno=30)

--Query 13. Display the name, job, and salary of all the employees whose job is MANAGER or ANALYST and their salary is not equal to 1000, 3000, or 5000. 
select ename,job,salary from employee where (job='manager' or job='analyst') and salary not in (1000,3000,5000)

--Query 14. Display the name, salary and commission for all employees whose commission amount is greater than their salary increased by 10%. 
select ename,salary,comm from employee where comm>salary*0.1

--Query 15. Display the name of all employees who have two Ls in their name and are in department 30 or their manager is 7782. 
select ename from employee where (ename like '%l%l' and deptno=30) or mgr_id=7782

--Query 16. Display the names of employees with experience of over 30 years and under 40 yrs.Count the total number of employees. 


--Query 17. Retrieve the names of departments in ascending order and their employees in descending order. 
select deptno,ename from employee order by deptno asc,ename desc

--Query 18. Find out experience of MILLER. 
select (year(getdate()) - year(convert(date, hiredate))) as Experience from employee where ename = 'Miller'
