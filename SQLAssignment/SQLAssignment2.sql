
--creating a database assignment2
create database assignment2

use assignment2

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
--Query 1. List all employees whose name begins with 'A'. 
select * from employee where ename LIKE 'A%'

--OR
select ename from employee where ename LIKE 'A%'

--Query 2. Select all those employees who don't have a manager.  
select* from employee where mgr_id is null

--OR
select* from employee where job='Manager'

--Query 3. List employee name, number and salary for those employees who earn in the range 1200 to 1400. 
select ename,empno,salary from employee where salary between 1200 and 1400

--Query 4. Give all the employees in the RESEARCH department a 10% pay rise. Verify that this has been done by listing all their details before and after the rise. 

--4.1 details before the pay rise
select* from employee where deptno=20

--4.2 Give a 10% pay rise to employees in the research department
update employee set salary=salary*0.10 where deptno=20

--4.3 List details after the pay rise
select* from employee where deptno=20

--Query 5. Find the number of CLERKS employed. Give it a descriptive heading. 
select count(*) as no_clerks from employee where job='clerk'

--Query 6.Find the average salary for each job type and the number of people employed in each job. 
select job,count(*) as no_employees,avg(salary) as avg_salary from employee group by job

--Query 7. List the employees with the lowest and highest salary. 

--7.1 employees with the lowest salary
select* from employee where salary=(select min(salary) from employee)

--7.2 employees with the highest salary
select* from employee where salary=(select max(salary) from employee)

--Query 8. List full details of departments that don't have any employees. 
select* from department where deptno not in(select distinct deptno from employee)

--Query 9. Get the names and salaries of all the analysts earning more than 1200 who are based in department 20. Sort the answer by ascending order of name. 
select ename,salary from employee where job='ANALYST' and salary>1200 and deptno=20 order by ename asc

--Query 10. For each department, list its name and number together with the total salary paid to employees in that department. 
select D.deptno,D.dname,sum(E.salary) as total_salary
from department D left join employee E on D.deptno=E.deptno group by D.deptno,D.dname order by D.DEptno

--Query 11. Find out salary of both MILLER and SMITH.
select ename,salary from employee where ename in ('miller','smith')

--Query 12. Find out the names of the employees whose name begin with ‘A’ or ‘M’. 
select ename from employee where ename like 'a%' or ename like 'm%'

--Query 13. Compute yearly salary of SMITH. 
select ename,salary*12 as Yearly_salary from employee where ename='Smith'

--Query 14. List the name and salary for all employees whose salary is not in the range of 1500 and 2850. 
select ename,salary from employee where salary<1500 or salary>2850

--Query 15. Find all managers who have more than 2 employees reporting to them
select mgr_id,count(*) as num_employees from employee where mgr_id is not null group by mgr_id 
having count(*)>2

--drop table employee
drop table employee

--drop table department
drop table department