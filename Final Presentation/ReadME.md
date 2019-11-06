# Software Development Life Cycle

## Requirements

| REQUIREMENT ID| REQUIREMENT NAME| REQUIREMENTS DESCRIPTION| TESTING METHOD|
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

### Minimum Requirements
* User/Customer is able to access website, browse media and contact the team for inquiries. Team members are able to upload media and interact with user requests. 

## Product Design

<details close>
<summary>KPM DESIGN</summary>
<p>
  
### INDEX
<img src = "https://github.com/juan-bustos/KPM/blob/master/Images/KPM-Index-Page.png" />

### PORTFOLIO PAGE
<img src = "https://github.com/juan-bustos/KPM/blob/master/Images/KPM-Portfolio-Page.png" />

### PHOTO SUBPAGE
<img src = "https://github.com/juan-bustos/KPM/blob/master/Images/KPM-Photo-Subpage.png" />

</p>
</details>

### Technologies Used
* KPM was created using the ASP.Net Core 3.0 Moderl View Controller structure. It relied heavily on C#, HTML, and CSS to create the basic functionality and overall appearance of the web application. Other technologies explored where Blazor, and some Javascript for additional features.
* Future technologies will include Blazor, additional Javascript, Google Maps for calculator integration, and custom CSS. 


# TESTING

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
### Review Findings
* Images are currently all displaying in the same container
* Need to further categorize images to add additional filters for storing images in correct containers
* Create communication functions between Customer and KPM Team
* Register and Login can be placed in one view instead of seperately
* Would like to add more custom controls/pages for team members to display personel work.

## Architecture and Code
### [**PROJECT CODE**](https://github.com/juan-bustos/KingPandaMedia/tree/master/KingPandaMedia/Project/KingPandaMedia)

## Demonstration
### https://kingpandamedia.azurewebsites.net/
### [**KPM***](https://kingpandamedia.azurewebsites.net/)
