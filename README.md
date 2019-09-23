<img src ="https://github.com/juan-bustos/KPM/blob/master/Images/KP%20Logo%20Final.png" />

# **TABLE OF CONTENTS**

1) [INTRODUCTION](https://github.com/juan-bustos/KPM#king-panda-media) <br>
2) [REQUIREMENTS](https://github.com/juan-bustos/KPM#requirements) <br>
3) [DATA DESIGN](https://github.com/juan-bustos/KPM#data-design) <br>
4) [UI DESIGN](https://github.com/juan-bustos/KPM#ui-design) <br>
5) [PROJECT PLAN](https://github.com/juan-bustos/KPM#project-plan) <br>
6) [PROJECT DEMO](https://github.com/juan-bustos/KPM#project-demo) <br>
7) [TEST REPORT](https://github.com/juan-bustos/KPM#test-report)


# KING PANDA MEDIA
### King Panda Media is primarily a multimedia company focused on providing the best product for various clientele ranging from commercial clients to the individual user.

[**^**](https://github.com/juan-bustos/KPM#table-of-contents)

# REQUIREMENTS

* **USER** 
	* 1.1 Account Creation
	* 1.2 Navigate through webpage
	* 1.3 See an estimate price for services provided
	* 1.4 Able to contact team / team members by e-mail
	* 1.5 Access/Ability to download personal imagery products ***(Future Update)***

* **SYSTEM**
	* 2.1 Verify Account Creation Form is Valid
	* 2.2 Ensure that User is not a bot
	* 2.3 Distinguishes between regular users and admin users

* **SOFTWARE**
	* 3.1 Ensure that webpage scales to device width for best user experience
	
[**^**](https://github.com/juan-bustos/KPM#table-of-contents)

# DATA DESIGN

### This is the basic Entity Relationship Diagram created for the KPM datatabase showcasing how the tables and different entities of the database interact with each other. As of now I am missing the attributes of each entity and I will be updating this in the future.

<img src = "https://github.com/juan-bustos/KPM/blob/master/Images/Database%20Diagram%20KPM.PNG" />

# ERD
<img src = "https://github.com/juan-bustos/KPM/blob/master/Images/Bustos%20Step%204%20ERD.png" />
<details close>
<summary>KPM DATABASE</summary>
<p>
	
````T-SQL Code
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
````
</p>
</details>

[**^**](https://github.com/juan-bustos/KPM#table-of-contents)

# UI DESIGN
### INDEX
<img src = "https://github.com/juan-bustos/KPM/blob/master/Images/KPM-Index-Page.png" />

### PORTFOLIO PAGE
<img src = "https://github.com/juan-bustos/KPM/blob/master/Images/KPM-Portfolio-Page.png" />

### PHOTO SUBPAGE
<img src = "https://github.com/juan-bustos/KPM/blob/master/Images/KPM-Photo-Subpage.png" />

### MULTIMEDIA SUBPAGE
<img src ="https://github.com/juan-bustos/KPM/blob/master/Images/KPM-Media-Subpage.png" />

[**^**](https://github.com/juan-bustos/KPM#table-of-contents)

# PROJECT PLAN

### QUOTE CALCULATOR
<img src ="https://github.com/juan-bustos/KPM/blob/master/Images/KPM-Calculator.png" />

[**^**](https://github.com/juan-bustos/KPM#table-of-contents)

# PROJECT DEMO

#### [KPM PROTOTYPE](https://kpmv2.conveyor.cloud/)

[**^**](https://github.com/juan-bustos/KPM#table-of-contents)

# TEST REPORT

| TEST ID| TEST CASE | REQUIREMENTS DESCRIPTION | STATUS |
| --- | --- | --- | --- |
| 1 | Account Creation | Customers and Team members need to create an account. | Not Implemented |
| 1.1 | Account Validation | System needs to validate proper authentication of user/account | Not Implemented |
| 1.2 | Account Filtering | System should be able to distinguish from admin users and regular users | Not Implemented |
| 2 | Site Creation | Complete website is created with functioning navigation, imagery, and other features | In Progress |
| 2.1 | Index Creation | Index has all features included from UI design | Implemented |
| 2.2 | Portfolio Creation | Portfolio page includes subsections for "Photo", "Video", and "Other" media | In Progress |
| 2.2.1 | Portfolio Creation | Portfolio products are able to be changed by Team Members | In Progress |
| 2.3 | Contact Creation | Contact Page has all features from Contact UI design | Not Implemented |
| 2.3.1 | Contact Creation | Contact Page allows members to upload/create their own products | Not Implemented |
| 2.4 | Quote Creation | Quote Button brings a drop down form to allow users to see an estimate of services | Not Implemented |
| 3 | Invoice Calculator | A calculator that allows users to see an estimate of services | Not Implemented |

[**^**](https://github.com/juan-bustos/KPM#table-of-contents)
