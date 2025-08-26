

CREATE TABLE employeeManager (
    id INT PRIMARY KEY,
    empName VARCHAR(100),
    salary DECIMAL(18,2),
    managerid INT
);
INSERT INTO employeeManager(id,empName,salary,managerid)VALUES(1,'Amulya',45000,2);
INSERT INTO employeeManager(id,empName,salary,managerid)VALUES(2,'Joe',95000,5);
INSERT INTO employeeManager(id,empName,salary,managerid)VALUES(3,'Smith',80000,2);
INSERT INTO employeeManager(id,empName,salary,managerid)VALUES(4,'Arun',50000,2);
INSERT INTO employeeManager(id,empName,salary,managerid)VALUES(5,'Anagha',75000,6);

SELECT e.empName AS EmployeeName, m.empName AS ManagerName
FROM employeeManager e
LEFT JOIN employeeManager m ON e.managerid = m.id
ORDER BY e.empName ASC;
