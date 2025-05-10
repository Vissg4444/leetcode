# Write your MySQL query statement below
Select Employees.name, EmployeeUNI.unique_id from Employees
Left Join EmployeeUNI on Employees.id = EmployeeUNI.id

