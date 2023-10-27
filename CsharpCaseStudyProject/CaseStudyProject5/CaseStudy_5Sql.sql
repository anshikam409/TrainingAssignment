create database casestudy_5
use casestudy_5

-- Create Students table

CREATE TABLE Students (
    Id INT PRIMARY KEY,
    Name NVARCHAR(255)
)

-- Create Courses table

CREATE TABLE Courses (
    CourseId INT PRIMARY KEY,
    CourseName NVARCHAR(255)
)

-- Create Enrollments table

CREATE TABLE Enrollments (
    EnrollmentId INT PRIMARY KEY,
    StudentId INT,
    CourseId INT,
    EnrollmentDate DATETIME,
    FOREIGN KEY (StudentId) REFERENCES Students(Id),
    FOREIGN KEY (CourseId) REFERENCES Courses(CourseId)
)

select* from Students
select* from courses
select* from Enrollments