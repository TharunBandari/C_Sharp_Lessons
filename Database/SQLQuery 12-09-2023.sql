use Northwind;

---GROUPING RULES---
SELECT COUNT(*) AS CustomerID FROM Customers;

SELECT SUM (Quantity) AS TotalUnits FROM [Order Details] WHERE ProductID=3;

SELECT AVG (UnitPrice) AS AveragePrice FROM Products;

SELECT City, COUNT (EmployeeID) AS NumEmployees FROM Employees GROUP BY City;

SELECT City, COUNT (EmployeeID) AS NumEmployees FROM Employees GROUP BY City HAVING COUNT (EmployeeID) > 1;

---FUNCTIONS---

SELECT DISTINCT City FROM Employees ORDER BY City

SELECT COUNT (DISTINCT City) AS NumCities FROM Employees

SELECT ProductID, SUM(Quantity) AS TotalUnits
FROM [Order Details]
GROUP BY ProductID
HAVING SUM(Quantity) < 200
ORDER BY TotalUnits;

SELECT ProductID, AVG (UnitPrice) AS AveragePrice FROM Products GROUP BY ProductID HAVING AVG (UnitPrice) > 70  ORDER BY AveragePrice;

SELECT CustomerID, COUNT (OrderID) AS NumOrders FROM Orders GROUP BY CustomerID HAVING COUNT (OrderID) > 15 ORDER BY NumOrders DESC;

SELECT ProductID, UnitPrice FROM Products WHERE UnitPrice > 70 ORDER BY UnitPrice;

---EXERCISE--

--Question 1 - List Freight as is and Freight rounded to the first decimal (e.g 1.150 becomes 1.200) from the Order tables--
SELECT Freight, ROUND(Freight,-2) AS ApproxFregiht FROM Orders;

--Question 2 - Select  the unit price as is and unit price as a CHAR(10) from the Product table--
SELECT UnitPrice, CAST (UnitPrice AS CHAR(10)) FROM Products;

SELECT UnitPrice, '$' + CAST(UnitPrice AS CHAR(10)) FROM Products;

SELECT UPPER (FirstNAME), UPPER(LastName) FROM Employees;

SELECT SUBSTRING (Address,1,10) FROM Customers;

--DATE FUNCTIONS--

SELECT LastName, BirthDate, HireDate, DATEDIFF(year,BirthDate,HireDate) AS HireAge FROM Employees ORDER BY HireAge;

SELECT FirstName,LastName,DATENAME(month,BirthDate) AS BirthMonth, DATEPART(month,BirthDate) FROM Employees ORDER BY DATEPART(month,BirthDate); 

--SUB QUERIES--

--Find the CustomerdID of the company that placed order 10290--
SELECT CustomerID FROM Orders WHERE OrderID = 10290;
--Find the name of the company that placed order 10290--
SELECT CompanyName FROM Customers WHERE CustomerID = (SELECT CustomerID FROM Orders --INCOMPLETE--

--Find the Companies that placed orders in 1997
SELECT CompanyName
FROM Customers
WHERE CustomerID IN (
  SELECT CustomerID
  FROM Orders
  WHERE OrderDate BETWEEN '1997-01-01' AND '1997-12-31'
);
SELECT CompanyName FROM Customers WHERE CustomerID IN (SELECT CustomerID FROM Orders WHERE OrderDate BETWEEN 1997-01-01 AND 1997-12-32);

--Create a query that shows the product name suppiler id for all product supplied by Exotic, Grandma Kelly HomeStead and Tokyo Traders. You will need to escape the apostrophe in "Grandma Kelly Homestead." To do so, please another apostrophe in fromt of it--
SELECT ProductName, SupplierID
FROM Products
WHERE SupplierID IN (
  SELECT SupplierID
  FROM Suppliers
  WHERE CompanyName IN ('Exotic', 'Grandma Kelly Home''stead', 'Tokyo Traders')
);
--Create a query that shows all products by name that are in the Seafood category--
SELECT ProductName FROM Products WHERE CategoryID = (SELECT CategoryID FROM Categories WHERE CategoryName = 'Seafood');

--Create a query that shows all companies by name that sell products in CategoryID 8
SELECT CompanyName FROM Suppliers WHERE SupplierID IN (SELECT SupplierID FROM Products WHERE CategoryID = 8);

--Create a query that shows all companies by name that sell products in the SeaFood category--
SELECT CompanyName FROM Suppliers WHERE SupplierID IN (SELECT SupplierID FROM Products WHERE CategoryID = (SELECT CategoryID FROM Categories WHERE CategoryName = 'Seafood'));

---JOINS---
--Type of JOINS--
/* Inner Joins - Left Join - Right Join - Union - Cross Join - Equi Join */
--EQUI JOIN vs INNER JOIN--
/*Inner join can have equality (=) and other operators (like <,>,<>) in the join condition.*/
/*Equi join only have equality (=)*/

--Create a report showing employee orders--
SELECT Employees.EmployeeID, Employees.FirstName, Employees.LastName, Orders.OrderId, Orders.OrderDate
FROM Employees
JOIN Orders ON Employees.EmployeeID = Orders.EmployeeID
ORDER BY Orders.OrderDate;

--Create a report showing employee orders using address--
SELECT e.EmployeeID,e.FirstName,e.LastName,o.OrderID,o.OrderID,o.OrderDate FROM Employees e Join Orders o ON (e.EmployeeID = o.EmployeeID) ORDER BY o.OrderDate;

--Multi Joins--
--Create a report showing the Order ID the name of the company that placed the order and the first and last name of the associated employee . Only shows orders placed after January 1, 1998 that shipped after they were required. Sort by Company Name--
SELECT
    Orders.OrderID,
    Customers.CompanyName AS CustomerName,
    Employees.FirstName AS EmployeeFirstName,
    Employees.LastName AS EmployeeLastName
FROM
    Orders
JOIN
    Customers ON Orders.CustomerID = Customers.CustomerID
JOIN
    Employees ON Orders.EmployeeID = Employees.EmployeeID
WHERE
    Orders.OrderDate > '1998-01-01'
    AND Orders.ShippedDate > Orders.RequiredDate
ORDER BY
    Customers.CompanyName;

--Inner Join--
--Create a report that shows the number of employees and customers from each city that has employees in it--
SELECT COUNT (DISTINCT e.EmployeeID) AS numEmployees,
	   COUNT (DISTINCT c.CustomerID) AS numCompanies,
	   e.City, c.City
FROM Employees e JOIN Customers c ON 
	 (e.City = c.City)
GROUP BY e.City, c.City
ORDER BY numEmployees DESC;

--Left Join--
--Create a report that shows the number of employees and customers from each city that has employeed in it--
SELECT COUNT (DISTINCT e.EmployeeID) AS numEmployees,
	   COUNT (DISTINCT c.CustomerID) AS numCompanies,
	   e.City, c.City
FROM Employees e LEFT JOIN Customers c ON 
	 (e.City = c.City)
GROUP BY e.City, c.City
ORDER BY numEmployees DESC;

--Right Join--
--Create a report that shows the number of employees and customers from each city that has employeed in it--
SELECT COUNT (DISTINCT e.EmployeeID) AS numEmployees,
	   COUNT (DISTINCT c.CustomerID) AS numCompanies,
	   e.City, c.City
FROM Employees e Right JOIN Customers c ON 
	 (e.City = c.City)
GROUP BY e.City, c.City
ORDER BY numEmployees DESC;

--Outer Join--
--Create a report that shows the number of employees and customers from each city that has employeed in it--
SELECT COUNT (DISTINCT e.EmployeeID) AS numEmployees,
	   COUNT (DISTINCT c.CustomerID) AS numCompanies,
	   e.City, c.City
FROM Employees e FULL JOIN Customers c ON 
	 (e.City = c.City)
GROUP BY e.City, c.City
ORDER BY numEmployees DESC;

--Unions--
--Get the phone number of all shippers, customer, and suppliers--
SELECT CompanyName,Phone 
FROM Shippers 
UNION
SELECT CompanyName,Phone
FROM Customers
UNION
SELECT CompanyName,Phone
FROM Suppliers
ORDER BY CompanyName;

--Create a report that shows the order ids and the associated employee names for orders that shipped after the required data. There should be 37 rows returned.--
SELECT
    Employees.FirstName,
    Employees.LastName,
    Orders.OrderID
FROM
    Orders
INNER JOIN
    Employees ON Orders.EmployeeID = Employees.EmployeeID
WHERE
    Orders.ShippedDate > Orders.RequiredDate

--Create a report that shows the total quantity of product (from the [Order Details] table) ordered. Only show records for product for which the quantity ordered is fewer than 200. The report should return following 5 rows--
Select p.ProductName, SUM(od.Quantity) AS TotalUnits 
FROM [Order Details] od JOIN Products p ON (p.ProductID=od.ProductID)
Group BY p.ProductName
Having SUM(Quantity)<200;

--Create a report that shows the total number of orders by Customer since December 31, 1996. The report should only return rows for which the NumOrders is greater than 15. The report should return the following 5 rows--
SELECT
    Customers.CompanyName,
    COUNT(Orders.OrderID) AS NumOrders
FROM
    Customers
LEFT JOIN
    Orders ON Customers.CustomerID = Orders.CustomerID
WHERE
    Orders.OrderDate > '31-Dec-1996'
GROUP BY
    Customers.CustomerID, Customers.CompanyName
HAVING
    COUNT(Orders.OrderID) > 15
ORDER BY NumOrders DESC;

SELECT
    Customers.CompanyName,
    COUNT(Orders.OrderID) AS NumOrders
FROM
    Customers
LEFT JOIN
    Orders ON Customers.CustomerID = Orders.CustomerID
WHERE
    Orders.OrderDate > '1996-12-31'
GROUP BY
    Customers.CustomerID, Customers.CompanyName
HAVING
    COUNT(Orders.OrderID) > 15
ORDER BY NumOrders DESC;

--Create a report that shows the company name order id and total price of all products of that has sold more than $10,000 worth.(There is no need for a GROUP BY clause in this report.)--

SELECT c.CompanyName, o.OrderID,

od.UnitPrice*od.Quantity*(1-od.Discount) AS TotalPrice
FROM [Order Details] od	
	Join Orders o On (o.OrderID=od.OrderId)
	Join Customers c ON (c.CustomerID=o.CustomerID)
Where od.UnitPrice* od.Quantity*(1-od.Discount)>10000
Order By TotalPrice DESC;

--create report showing the contact name and phone numbers for all employees, customers and suppliers--
SELECT ContactName, Phone
FROM Employees
UNION
SELECT ContactName, Phone
FROM Customers
UNION
SELECT ContactName , Phone
FROM Suppliers
ORDER BY ContactName;

--TRANSACTION and COMMIT--
USE Northwind
GO
BEGIN TRANSACTION
UPDATE dbo.Categories
SET CategoryName = 'FishFood_Thaurn'
WHERE CategoryName = 'Seafood';
ROLLBACK TRANSACTION 
commit TRANSACTION

SELECT * FROM dbo.Categories
BEGIN TRANSACTION
UPDATE dbo.Categories
SET CategoryName = 'Seafood'
WHERE CategoryName = 'Fishfood';
ROLLBACK TRANSACTION
SELECT * FROM dbo.Categories

--Self Join--
Select EmployeeID, FirstName,ReportsTo,Title 
From Employees
Select e1.EmployeeID, e1.FirstName,e2.FirstName as managerName, e1.Title 
From Employees e1 Inner Join Employees e2 on e1.ReportsTo=e2.EmployeeID;

SELECT * FROM Orders WHERE freight in (SELECT Freight FROM orders order by Freight desc);

SELECT * FROM Orders WHERE freight in (SELECT top 3 freight from Orders order by freight desc);

SELECT min (BirthDate) 
FROM (SELECT top 3 from Employees order by BirthDate desc) a;

SELECT MIN (WORKDATE)
FROM Employees WHERE BirthDate in (SELECT TOP 3 FROM Employees order by BirthDate desc) a;


/*
SELECT FROM emp join dept using deptno - equi join
SELECT FROM emp using dept on(e.deptno > d.deptno)
*/

--How to find the Second / third or the nth max salary reciver from the Employee Table--

use tempdb
SELECT * FROM Tharun where salary =
(SELECT Max(salary) from Tharun where sal <
(select max(salary) from Tharun where sal <
(select max(salary) from Tharun)));
--How to find the second / third or the nth Oldest Person from the Employee Table --

SELECT orderid.freight
from orders
order by Freight desc;

SELECT Min(freight) from (Select top 3 freight from orders order by Freight desc) a

--Indexing-- 



