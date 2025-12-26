--Day 8: SQL BASICS

--SELECT
select * from Employees;

--WHERE
select * from Employees where Salary>5000;

--Order By
select * from Employees Order by salary desc;

--Inner Join
select e.Name,d.departmentName from Employees e inner join 
Departments d ON e.deptId=d.Id;

--Left Join
Select e.Name,d.departmentName from Employees 
Left join Departments On e.DeptId=d.Id;

--Group By
Select DeptId,Count(*)
from Employees
Group By DeptId;

--Having
Select DeptId,Count(*)
from Employees
Group by DeptId
Having Count(*)>3;


