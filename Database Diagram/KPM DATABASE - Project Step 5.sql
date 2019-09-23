-----Creating and using database-----
DROP DATABASE IF EXISTS KPM;
CREATE DATABASE KPM;
USE KPM;
----- START OF PRODUCTS TABLE -----
DROP TABLE IF EXISTS
Products;

CREATE TABLE
Products
(
	productID	INT  NOT NULL
	, photoID	INT  NULL
	, videoID	INT  NULL
	, graphicID INT  NULL
	, packagename VARCHAR(20) NOT NULL
	, unitprice DECIMAL NOT NULL
	, CONSTRAINT PK_ProductID 
	PRIMARY KEY (productID)
)
INSERT INTO Products
	(productID, photoID, videoID, graphicID, 
	packagename, unitprice)
VALUES
 (1,1,0,0, 'Basic', 99.0)
,(2,2,1,0, 'Advanced', 199.0)
,(3,0,2,1, 'Advanced', 199.0)
,(4,3,0,0, 'Basic', 99.0)
,(5,4,3,2, 'Premium', 299.0)
,(6,5,4,3, 'Premium', 299.0)
----- END OF PRODUCTS TABLE -----

----- START OF SALES TABLE -----
DROP TABLE IF EXISTS
Orders;

CREATE TABLE
Orders
(
	orderID	INT  NOT NULL
	, productID INT NOT NULL
	, custID	INT  NULL
	, empID	INT  NULL
	, orderdate DATE   
	, CONSTRAINT PK_OrderID
	PRIMARY KEY (orderID)
	, CONSTRAINT FK_ProductID
	FOREIGN KEY (productID) REFERENCES Products(productID)
	, CONSTRAINT FK_Teams
	FOREIGN KEY (empID) REFERENCES Teams (empID) 
	, CONSTRAINT FK_custID
	FOREIGN KEY  (custId) REFERENCES Customers (custID)
)

INSERT INTO Orders
	(orderID, productID, custID, empID, 
	orderdate)
VALUES
 (1,1,1,1, GETDATE())
,(2,2,3,1, GETDATE())
,(3,3,3,2, GETDATE())
,(4,4,4,1, GETDATE())
,(5,5,5,2, GETDATE())
,(6,6,2,3, GETDATE())
----- END OF SALES TABLE -----

----- START OF TEAMS TABLE -----
DROP TABLE IF EXISTS
Teams;

CREATE TABLE
Teams
(
	empID	INT  NOT NULL
	, LastName NVARCHAR(20) NOT NULL
	, FirstName NVARCHAR(20) NOT NULL
	, Title NVARCHAR(10) NULL
	, hiredate DATE
	, birthdate DATE
	, CONSTRAINT PK_EmpID
	PRIMARY KEY (empID)
)

INSERT INTO Teams
	(empID, LastName, FirstName, hiredate, 
	birthdate)
VALUES
 (1,'Bustos','Juan', GETDATE(), '1993-05-18')
,(2,'McCloud','Jesus', GETDATE(), '1996-01-19')
,(3,'Auvert','Daniel', GETDATE(), '1995-04-26')

----- END OF TEAMS TABLE -----

----- START OF CUSTOMERS TABLE -----
DROP TABLE IF EXISTS
Customers;

CREATE TABLE
Customers
(
	custID	INT  NOT NULL
	, orderID	INT  NOT NULL
	, productID INT NOT NULL
	, LastName NVARCHAR(20) NOT NULL
	, FirstName NVARCHAR(20) NOT NULL
	, CONSTRAINT PK_custID
	PRIMARY KEY (custId)
	, CONSTRAINT FK_ProductID
	FOREIGN KEY (productID) REFERENCES Products(productID)
	, CONSTRAINT FK_OrderID
	FOREIGN KEY (orderID) REFERENCES Orders(orderID)
)

INSERT INTO Customers
	(custID, LastName, FirstName, orderID, 
	productID)
VALUES
 (1,'Ostrowski','Larisa', 1, 1)
,(2,'Saller','Perez ', 2, 2)
,(3,'Aaldenberg','Tjaard', 3, 3)
,(4,'Crnevi','Narkissos', 4, 4)
,(5,'Carbone','Alem ', 3, 5)
,(6,'Reed','Bella', 5, 6)

----- END OF CUSTOMERS TABLE -----
