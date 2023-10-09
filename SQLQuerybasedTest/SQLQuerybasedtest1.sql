--creating database
create database sqltest1

--use that database
use sqltest1
--creating table books
create table books(
id int primary key,title varchar(100),author varchar(50), isbn numeric(20) unique,published_date date
)

--inserting values in table books
insert into books values(1,'My First SQL book','Mary Parker',981483029127,'2012-02-22 12:00')
insert into books values(2,'My Second SQL book','John Mayer',857300923713,'1972-07-03 9:20')
insert into books values(3,'My Third SQL book','Cary Flint',523120967812,'2015-10-18 14:05')

--selecting values of table books
select* from books

--Query 1.   Write a query to fetch the details of the books written by author whose name ends with er.

select* from books where author LIKE '%er'

--creating a table reviews
create table reviews(
id int foreign key (id) references books (id),book_id int,reviewer_name varchar(50),content varchar(50),rating int, published_date date
)

--inserting values in the table reviews
insert into reviews values(1,1,'John Smith','My first review',4,'2017-12-10 05:50')
insert into reviews values(2,2,'John Smith','My second review',5,'2017-10-13 15:05')
insert into reviews values(3,2,'Alice Walker','Another review',1,'2017-10-22 23:47') 

--selecting table reviews 
select* from reviews

--Query 2. Display the Title ,Author and ReviewerName for all the books from the above table 

select B.title,B.author,R.reviewer_name from reviews R
join books B on R.book_id=B.id

--Query 3. Display the  reviewer name who reviewed more than one book.
select reviewer_name from reviews group by reviewer_name
having count(distinct book_id)>1

--creating table customer
create table Customer (
    CustomerID int primary key,Name VARCHAR(255), Age INT,Address VARCHAR(255),Salary DECIMAL(10, 2))

-- Inserting values in Customers table
insert into Customer values (1, 'Ramesh', 32, 'Ahmedabad', 200.00)
insert into Customer values (2, 'Khilan', 25, 'Delhi', 1500.00)
insert into Customer values (3, 'Kaushik', 23, 'Kota', 2000.00)
insert into Customer values (4, 'Chaitali', 25, 'Mumbai', 6500.00)
insert into Customer values (5, 'Hardik', 27, 'Bhopal', 8500.00)
insert into Customer values (6, 'Komal', 22, 'MP', 4500.00)
insert into Customer values (7, 'Muffy', 24, 'Indore', 10000.00)

--selecting table customer
select* from customer

--Query 4. Display the Name for the customer from above customer table  who live in same address which has character o anywhere in address
select name from customer where address Like '%o%'

-- Creating table for orders
CREATE TABLE ORDERS (
Order_ID INT,Order_Date DATE,Customer_ID INT,Amount INT
)

-- Inserting values in ORDERS table
insert into orders values(102, '2009-10-08', 3, 3000)
insert into orders values(100, '2009-10-08', 3, 1500)
insert into orders values(101, '2009-11-20', 2, 1560)
insert into orders values(103, '2008-05-20', 4, 2060)

--selecting values of table orders
select* from orders

--Query 5. Write a query to display the   Date,Total no of customer  placed order on same Date 
select Order_Date,count(distinct Customer_ID) as total_Customers from Orders group by Order_Date

--creating table employee
create table employee (
    employeeID int primary key,Name VARCHAR(255), Age INT,Address VARCHAR(255),Salary DECIMAL(10, 2))

--inserting values in table employee
insert into employee values (1, 'Ramesh', 32, 'Ahmedabad', 200.00)
insert into employee values (2, 'Khilan', 25, 'Delhi', 1500.00)
insert into employee values (3, 'Kaushik', 23, 'Kota', 2000.00)
insert into employee values (4, 'Chaitali', 25, 'Mumbai', 6500.00)
insert into employee values (5, 'Hardik', 27, 'Bhopal', 8500.00)
insert into employee values (6, 'Komal', 22, 'MP', null)
insert into employee values (7, 'Muffy', 24, 'Indore',null)

--selecting values of table employee
select* from employee

--Query 6. Display the Names of the Employee in lower case, whose salary is null 
select lower(name)  as lowercaseemployeename from employee where salary is null

--creating table studentdetails
create table studentdetails(
id int primary key,register_no int, name varchar(50),age int, qualification varchar(100),mobile_no numeric(10), mail_id varchar(225),Location varchar(225),Gender Varchar(50)
)

--inserting values studentdetails table
insert into studentdetails values(1,2,'Sai',22,'B.E',9952836777,'Sai@gmail.com','Chennai','M')
insert into studentdetails values(2,3,'Kumar',22,'B.Sc',7890125648,'Kumar@gmail.com','Madhurai','M')
insert into studentdetails values(3,4,'Salvi',22,'B.Tech',8904567342,'salvi@gmail.com','selam','F')
insert into studentdetails values(4,5,'Nisha',22,'M.E',7834672310,'nisha@gmail.com','Theni','F')
insert into studentdetails values(5,6,'Sai saran',22,'B.A',7890345678,'Saran@gmail.com','Madurai','F')
insert into studentdetails values(6,7,'Tom',22,'BCA',8901234675,'tom@gmail.com','Pune','M')

--selecting values from the table studentdetails
select* from studentdetails

--Query 7. Write a sql server query to display the Gender,Total no of male and female from the above relation
select Gender,count(*) as total from studentdetails group by Gender
