use Northwind;

SELECT * FROM Employees

SELECT EmployeeID , FirstName, LastName, HireDate, City
FROM Employees;

SELECT EmployeeID , FirstName, LastName, HireDate, City
FROM Employees
WHERE City = 'London';

SELECT EmployeeID , FirstName, LastName, HireDate, City
FROM Employees
WHERE City <> 'London';

SELECT EmployeeID , FirstName, LastName, HireDate, City
FROM Employees
WHERE HireDate = '19-December-2789';

SELECT CategoryName ,Description 
FROM Categories;

SELECT ContactName, CompanyName, ContactTitle, Phone
FROM Customers;

SELECT EmployeeID, Title, FirstName, LastName, Region
FROM Employees;

SELECT RegionID, RegionDescription 
FROM Region;

SELECT CompanyName, Fax, Phone, HomePage 
FROM Suppliers;

SELECT EmployeeID, FirstName, LastName, LastName, HireDate, City 
FROM Employees
WHERE (HireDate >= '1-june-1992') AND (HireDate <= '15-december-1993') 

SELECT EmployeeID, FirstName, LastName, LastName, HireDate, City 
FROM Employees
WHERE HireDate BETWEEN '1-june-1992' AND '15-december-1993'

SELECT EmployeeID, FirstName, LastName, LastName, HireDate, City 
FROM Employees
WHERE HireDate NOT BETWEEN '1-june-1992' AND '15-december-1993'

SELECT EmployeeID, FirstName, LastName, LastName, HireDate, City 
FROM Employees
WHERE City = 'London' OR City = 'Seattle'

SELECT EmployeeID, FirstName, LastName, HireDate, City
From Employees 
Where City IN('Seattle', 'Tacoma', 'Redmond')
 
SELECT EmployeeID, FirstName, LastName, HireDate, City
From Employees 
Where City NOT IN('Seattle', 'Tacoma', 'Redmond')

SELECT EmployeeID, FirstName, LastName, LastName, HireDate, City 
FROM Employees
WHERE (FirstName NOT LIKE 'M%') AND (FirstName NOT LIKE 'A%')

SELECT EmployeeID, FirstName, LastName, LastName, HireDate, City 
FROM Employees
WHERE FirstName LIKE '[a-M]%'

SELECT EmployeeID, FirstName, LastName, LastName, HireDate, City 
FROM Employees
WHERE FirstName LIKE '[^a-M]%'

/* ORDER BY */

SELECT EmployeeID, FirstName, LastName, LastName, HireDate, City 
FROM Employees
ORDER BY City

SELECT EmployeeID, FirstName, LastName, LastName, HireDate, Country, City 
FROM Employees
ORDER BY Country, City DESC

SELECT EmployeeID, FirstName, LastName, LastName, HireDate, Country, City 
FROM Employees
ORDER BY Country DESC, City DESC

SELECT EmployeeID, FirstName, LastName, LastName, HireDate, Country, City 
FROM Employees
ORDER BY Country ASC, City DESC

SELECT Title, FirstName, LastName
FROM Employees
ORDER BY 1,3;

SELECT Title, FirstName, LastName
FROM Employees
ORDER BY Title,LastName;

SELECT CategoryName, Description 
FROM Categories
ORDER BY CategoryName

SELECT ContactName, CompanyName, ContactTitle,Phone 
FROM Customers
ORDER BY Phone

SELECT FirstName, LastName, HireDate 
FROM Employees
ORDER BY HireDate DESC

SELECT OrderID, OrderDate, ShippedDate, CustomerID, Freight
FROM Orders
ORDER BY Freight DESC

/* 
1) List CategoryName and Description from the Categories table sorted by CategoryName
SELECT CategoryName, Description 
FROM Categories
ORDER BY CategoryName
2) Display ContactName, CompanyName, ContactTitle, and Phone from the Customers tables sorted by Phone.
SELECT ContactName, CompanyName, ContactTitle,Phone 
FROM Customers
ORDER BY Phone
3) Create a Query showing employees first and last name and hire dates sorted from newest to oldest employee
SELECT FirstName, LastName, HireDate 
FROM Employees
ORDER BY HireDate DESC
4) Create a query showing orders sorted by Freight from most expensive to cheapest. Show OrderID, OrderDate, ShippedDate, CustomerID, and Freight.
SELECT OrderID, OrderDate, ShippedDate, CustomerID, Freight
FROM Orders
ORDER BY Freight DESC
5) Select CompanyName, Fax, Phone, HomePage and Country from the suppilers table sorted by Country in descending order and then by CompanyName in ascending order.
SELECT CompanyName, Fax, Phone, HomePage, Country
FROM Suppliers
ORDER BY Country DESC, CompanyName ASC
6) Create a list of employees showing titlename and last name Sorted by title ascending order and then by lastName in descending order.
SELECT Title, LastName 
FROM Employees
ORDER BY Title ASC, LastName DESC
7) Create a query showing all the company names and contacts names of customer in Buenos Aires.
SELECT CompanyName, ContactName
FROM Customers 
WHERE City='Buenos Aires';
8) Create a query showing the product name  Unit price and quantity per unit of all product that are out of stock
SELECT ProductName, UnitPrice, QuantityPerUnit
FROM Products
WHERE UnitPrice=0;
9) Create a query showing the order date, shippied date, customer id, and freight if all orders placed on May 19, 1997.
SELECT OrderDate, ShippedDate, CustomerID, Freight
FROM Orders
WHERE OrderDate = '19-05-1997';
10) Create a query showing thr FirstName, LastName and country of all employees not in the United States.
SELECT FirstName, LastName, Country
FROM Employees
WHERE Country <> 'United States';
*/

SELECT FirstName, LastName, Country 
FROM Em
WHERE Country is Null;

SELECT ProductName, UnitPrice, QuantityPerUnit
FROM Products
WHERE UnitPrice=0;

SELECT OrderDate, ShippedDate, CustomerID, Freight
FROM Orders
WHERE OrderDate = '19-05-1997';


SELECT Title, LastName 
FROM Employees
ORDER BY Title ASC, LastName DESC

SELECT CompanyName, ContactName
FROM Customers 
WHERE City='Buenos Aires';





SELECT CompanyName, Fax, Phone, HomePage, Country
FROM Suppliers
ORDER BY Country DESC, CompanyName ASC

SELECT OrderID, OrderDate, ShippedDate, CustomerID, Freight
FROM Orders
ORDER BY Freight DESC




/*NULL*/
SELECT FirstName,LastName, Region
FROM Employees
WHERE Region IS NULL;

SELECT FirstName,LastName, Region
FROM Employees
WHERE Region IS NOT NULL;

SELECT FirstName +' '+ LastName
FROM Employees

SELECT [OrderID],[Freight],[Freight]*0.1 Tax
FROM [Orders]
WHERE Freight >= 500;

SELECT OrderID,Freight,Freight*1.1 AS FreightTotal
FROM Orders
WHERE Freight >= 500;







