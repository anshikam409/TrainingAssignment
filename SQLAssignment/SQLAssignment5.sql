create database Assignment5
use Assignment5

-- Question 1. Write a T-SQL based procedure Program to generate complete payslip of a given employee with respect to the following condition
--a)	HRA  as 10% Of sal
--b)	DA as  20% of sal
--c)	PF as 8% of sal
--d)	IT as 5% of sal
--e)	Deductions as sum of PF and IT
--f)	Gross Salary as sum of SAL,HRA,DA 
--g)	Net salary as  Gross salary- Deduction

CREATE PROCEDURE GeneratePayslip
    @EmployeeID INT,
    @Salary DECIMAL(18, 2)
AS
BEGIN
    DECLARE @HRA DECIMAL(18, 2)
    DECLARE @DA DECIMAL(18, 2)
    DECLARE @PF DECIMAL(18, 2)
    DECLARE @IT DECIMAL(18, 2)
    DECLARE @Deductions DECIMAL(18, 2)
    DECLARE @GrossSalary DECIMAL(18, 2)
    DECLARE @NetSalary DECIMAL(18, 2)
    -- Calculate HRA, DA, PF, IT
    SET @HRA = 0.1 * @Salary
    SET @DA = 0.2 * @Salary
    SET @PF = 0.08 * @Salary
    SET @IT = 0.05 * @Salary
    -- Calculate Deductions
    SET @Deductions = @PF + @IT
    -- Calculate Gross Salary
    SET @GrossSalary = @Salary + @HRA + @DA
    -- Calculate Net Salary
    SET @NetSalary = @GrossSalary - @Deductions
    -- Output the payslip
    SELECT
        @EmployeeID AS EmployeeID,
        @Salary AS BasicSalary,
        @HRA AS HRA,
        @DA AS DA,
        @PF AS PF,
        @IT AS IT,
        @Deductions AS Deductions,
        @GrossSalary AS GrossSalary,
        @NetSalary AS NetSalary
END


EXEC GeneratePayslip @EmployeeID = 1, @Salary = 50000.00
EXEC GeneratePayslip @EmployeeID=2, @Salary=70000.00