--Index
Create Nonclustered index idx_salary ON Employees(salary);

--Clustered Index
--Usually created by Primary Key

--Normalization
--Stored Procedure

Create Procedure GetEmployees
as 
Begin
select * from Employees;
End;

--Function
Create Function GetEmployeeCount()
Returns INT
As
Begin
 Return(select count(*) from employees);
End;

--Transaction
Begin Transaction;
Update Employees set salary=salary+1000;
Commit;
