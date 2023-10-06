create database anshikaassignment1
use anshikaassignment1
--Creating table Clients
create table Clients(
Client_ID numeric(4) Primary Key,Cname VARCHAR(40) Not Null,Address VARCHAR(30),Email VARCHAR(30) Unique,Phone numeric(10),Business VARCHAR(20) Not Null
)
--insering values in table client
insert into Clients values(1001,'ACME Utilities','Noida','contact@acmeutil.com',9567880032,'Manufacturing')
insert into Clients values(1002,'Trackon Consultants','Mumbai','consult@trackon.com',8734210090,'Consultant')
insert into Clients values(1003,'MoneySaver Distributors','Kolkata','save@moneysaver.com',7799886655,'Reseller')
insert into Clients values(1004,'Lawful Corp','Chennai','justice@lawful.com',9210342219,'Professional')
--selecting all values from table client
select* from Clients
--creating table Departments
create table Departments(
Deptno numeric(2) Primary Key,Dname VARCHAR(15)	Not Null,Loc VARCHAR(20)		
)
--inserting values in table departments
insert into Departments values(10,'Design','Pune')
insert into Departments values(20,'Development','Pune')
insert into Departments values(30,'Testing','Mumbai')
insert into Departments values(40,'Document','Mumbai')
--selecting all values from table departments
select* from Departments
--create table Employees
create table Employees(
Empno numeric(4) Primary Key,Ename VARCHAR(20) Not Null,Job VARCHAR(15),Salary numeric(7) check (salary>0),Deptno numeric(2) Foreign Key (Deptno) references Departments(Deptno)
)
--inserting values in table employees
insert into Employees values(7001,'Sandeep','Analyst',25000,10)
insert into Employees values(7002,'Rajesh','Designer',30000,10)
insert into Employees values(7003,'Madhav','Developer',40000,20)
insert into Employees values(7004,'Manoj','Developer',40000,20)
insert into Employees values(7005,'Abhay','Designer',35000,10)
insert into Employees values(7006,'Uma','Tester',30000,30)
insert into Employees values(7007,'Gita','Tech. Writer',30000,40)
insert into Employees values(7008,'Priya','Tester',35000,30)
insert into Employees values(7009,'Nutan',	'Developer',45000,20)
insert into Employees values(7010,'Smita','Analyst',20000,10)
insert into Employees values(7011,'Anand','Project Mgr',65000,10)
--selecting all values from table employees
select* from Employees
--creating table projects
create table Projects(
Project_ID numeric(3) Primary Key,Descr	VARCHAR(30)	Not Null,Start_Date	DATE,Planned_End_Date DATE,Actual_End_date DATE,Budget numeric(10) check (Budget>0),Client_ID numeric(4) Foreign Key (Client_ID) references Clients (Client_ID)
)
--inserting values in table Projects
insert into Projects values(401,'Inventory','01-Apr-11','01-Oct-11','31-Oct-11',150000,1001)
insert into Projects values(402,'Accounting','01-Aug-11','01-Jan-12',Null,500000,1002)
insert into Projects values(403,'Payroll','01-Oct-11','31-Dec-11',Null,75000,1003)
insert into Projects values(404,'Contact Mgmt','01-Nov-11','31-Dec-11',Null,50000,1004)
--selecting all values from the table 
select* from Projects
--creating table EmpProjectstasks
create table EmpProjectTasks(
Project_ID numeric(3),Empno numeric(4),Start_Date DATE,End_Date DATE,Task VARCHAR(25) Not Null,Status VARCHAR(15) Not Null , Foreign key (Project_ID) references projects (Project_ID),Foreign key (Empno) references Employees(Empno),Primary Key(Project_ID,Empno)
)
--inserting values in the table EmpProjecttasks
insert into EmpProjectTasks values(401,7001,'01-Apr-11','20-Apr-11','System Analysis','Completed')
insert into EmpProjectTasks values(401,7002,'21-Apr-11','30-May-11','System Design','Completed')
insert into EmpProjectTasks values(401,7003,'01-Jun-11','15-Jul-11','Coding','Completed')
insert into EmpProjectTasks values(401,7004,'18-Jul-11','01-Sep-11','Coding','Completed')
insert into EmpProjectTasks values(401,7006,'03-Sep-11','15-Sep-11','Testing','Completed')
insert into EmpProjectTasks values(401,7009,'18-Sep-11','05-Oct-11','Code Change','Completed')
insert into EmpProjectTasks values(401,7008,'06-Oct-11','16-Oct-11','Testing','Completed')
insert into EmpProjectTasks values(401,7007,'06-Oct-11','22-Oct-11','Documentation','Completed')
insert into EmpProjectTasks values(401,7011,'22-Oct-11','31-Oct-11','Sign off','Completed')
insert into EmpProjectTasks values(402,7010,'01-Aug-11','20-Aug-11','System Analysis','Completed')
insert into EmpProjectTasks values(402,7002,'22-Aug-11','30-Sep-11','System Design','Completed')
insert into EmpProjectTasks values(402,7004,'01-Oct-11',null,'Coding','In Progress')
--selecting all values from the table EmpProjectTasks
select* from EmpProjectTasks