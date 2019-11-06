<img src ="https://github.com/juan-bustos/KingPandaMedia/blob/master/Images/KP%20Logo%20Final.png" />

# **TABLE OF CONTENTS**

1) [INTRODUCTION](https://github.com/juan-bustos/KingPandaMedia/blob/master/README.md#tableofcontents) <br>
2) [REQUIREMENTS](https://github.com/juan-bustos/KingPandaMedia/blob/master/README.md#requirements) <br>
3) [DATA DESIGN](https://github.com/juan-bustos/KPM#data-design) <br>
4) [UI DESIGN](https://github.com/juan-bustos/KPM#ui-design) <br>
5) [PROJECT PLAN](https://github.com/juan-bustos/KPM#project-plan) <br>
6) [PROJECT DEMO](https://github.com/juan-bustos/KPM#project-demo) <br>
7) [TEST REPORT](https://github.com/juan-bustos/KPM#test-report)


# KING PANDA MEDIA
### King Panda Media is primarily a multimedia company focused on providing the best product for various clientele ranging from commercial clients to the individual user.

[**^**](https://github.com/juan-bustos/KingPandaMedia/blob/master/README.md#table-of-contents)


# REQUIREMENTS 
| REQUIREMENTS ID| REQUIREMENT NAME| REQUIREMENTS DESCRIPTION| TESTING METHOD|
| --- | --- | --- | --- |
| 1 | Create Users | System shall allow users to be created | Inspection |
| 1.1 | User Forms | System shall allow users to input personal information for creating account | Inspection |
| 1.2 | Authenticate Forms | System shall ensure that form is filled out correctly | Inspection |
| 1.3 | Third-Party Authentication | System shall allow for third party authentication | Inspection |
| 2 | Authenticate User | System shall ensure that user is created successfully | Inspection |
| 3 | Login Users | System shall login users through e-mail and password | Inspection |
| 4 | Upload Media | System shall allow Team Member users to upload media | Inspection |
| 5 | Display Media | System shall show media that is uploaded | Inspection |
| 6 |  Delete Users | System shall allow admin to delete users | Inspection |
| 7 |  Edit User Roles | System shall allow admin to edit user roles as needed | Inspection |
| 8 |  Add User Roles | System shall allow admin to add user roles as needed | Inspection |
| 9 | Delete User Roles | System shall allow admin to delete user roles as needed | Inspection |
| 10 | Delete Uploaded Media | System shall allow admin / team users to delete uploaded media | Inspection |
| 11 | Admin Controls | System shall allow admin user to moderate web page | Inspection |
	
[**^**](https://github.com/juan-bustos/KPM#table-of-contents)

# DATA DESIGN

### This is the basic Entity Relationship Diagram created for the KPM datatabase showcasing how the tables and different entities of the database interact with each other. As of now I am missing the attributes of each entity and I will be updating this in the future.

<img src = "https://github.com/juan-bustos/KingPandaMedia/blob/master/Images/Code%20First%20Database%20Diagram%20KPM.PNG" />

# ERD
<img src = "https://github.com/juan-bustos/KingPandaMedia/blob/master/Images/Bustos%20Step%204%20ERD.png" />
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
<img src = "https://github.com/juan-bustos/KingPandaMedia/blob/master/Images/KPM-Index-Page.png" />

### PORTFOLIO PAGE
<img src = "https://github.com/juan-bustos/KingPandaMedia/blob/master/Images/KPM-Portfolio-Page.png" />

### PHOTO SUBPAGE
<img src = "https://github.com/juan-bustos/KingPandaMedia/blob/master/Images/KPM-Photo-Subpage.png" />


[**^**](https://github.com/juan-bustos/KPM#table-of-contents)

# PROJECT PLAN

### QUOTE CALCULATOR
<img src ="https://github.com/juan-bustos/KingPandaMedia/blob/master/Images/KPM-Calculator.png" />

[**^**](https://github.com/juan-bustos/KPM#table-of-contents)

# PROJECT DEMO

#### [King Panda Media](https://kingpandamedia.azurewebsites.net/)

[**^**](https://github.com/juan-bustos/KPM#table-of-contents)

# TEST REPORT

# TESTING
### Entrance Criteria 
| TEST DESCRIPTION| TEST STEPS | EXPECTED RESULTS | REQUIREMENT | PASS/FAIL |
| --- | --- | --- | --- | --- |
| User fills out form and registers account | 1. Go to Register Page <BR/> 2. Fill out form <BR/> 3. Click Register | User is created and redirected to Home Page | 1, 1.1, 1.2, 2 | PASS |
| User logs in with existing account | 1. Go to website <BR /> 2. Click Login <BR /> 3. Enter User Information <BR /> 4. Click Log In Button at the end of form | User is logged in, redirected to Home Page, and Navbar changes to show a welcome message, and logout option. | 2, 3 | PASS |
| Team Member User is able to upload media. | 1. Go to a portfolio page <BR /> 2. If user is in correct role they will see a upload files button. <BR /> 3. Click "browse" <BR /> 4. Select an image <BR /> 5. Click Upload | User will be able to select a media file and after clicking upload will be redirected to the same page with their media uploaded. | 4, 5 | PASS |
| Admin Controls | 1. Admin User Logs in <BR /> 2. Click the Admin button <BR /> 3. Admin page displays <BR /> 4. Series of buttons will show to create roles, view roles, delete users, delete media | Admin view will show along with buttons redirecting to all of the different admin controls. | 6,8,9,10 | PASS |

### Requirements Traceability
| ID| Create Users | Authenticate Users | Upload Media | CRUD Operations |
| --- | --- | --- | --- | --- |
|1| PASS |
|1.1| PASS
|1.2| PASS
|2| PASS | PASS
|3| | PASS
|4| | | PASS
|5| | | PASS
|6| | | |PASS
|7| | | |PASS
|8| | | |PASS
|9| | | |PASS
|10| | | |PASS
|11| | | |PASS

### 90% of Requirements are linked to test cases. 

### Exit Criteria 
| ID | TEST DESCRIPTION| TEST STEPS | DATE | REQUIREMENT | PASS/FAIL |
| --- | --- | --- | --- | --- | --- |
| 1 | User fills out form and registers account | 1. Go to Register Page <BR/> 2. Fill out form <BR/> 3. Click Register | 2019/10/15 | 1, 1.1, 1.2, 2 | PASS |
| 2 | User logs in with existing account | 1. Go to website <BR /> 2. Click Login <BR /> 3. Enter User Information <BR /> 4. Click Log In Button at the end of form | 2019/10/15 | 2, 3 | PASS |
| 3 | Team Member User is able to upload media. | 1. Go to a portfolio page <BR /> 2. If user is in correct role they will see a upload files button. <BR /> 3. Click "browse" <BR /> 4. Select an image <BR /> 5. Click Upload | 2019/10/15 | 4, 5 | PASS |
|4 | Admin Controls | 1. Admin User Logs in <BR /> 2. Click the Admin button <BR /> 3. Admin page displays <BR /> 4. Series of buttons will show to create roles, view roles, delete users, delete media | 2019/10/15 | 6,8,9,10 | PASS |

### 100% of tests are passing.

* **FINDINGS** 
	* Not all media is showing on correct web pages
	* Need to implement more CRUD controls
	* Work on scaling images based on dimensions

[**^**](https://github.com/juan-bustos/KPM#table-of-contents)
