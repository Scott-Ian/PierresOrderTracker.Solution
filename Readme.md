# _Pierres Order Tracker_

#### _A web application for listing, adding, and removing clients and their orders from lists_

#### By _**Ian Scott**_

## Description

_This is a sample web application that manages vendors and order purchases for venders. It provides a list of all vendors, the ability to add, edit, and delete vendors, as well as the ability to add orders to a vendor._

### Specifications
| | Spec | Input | Output | isComplete |
| :-------------     | :-------------     | :------------- | :------------- |:------------- |
|1.|The program can instantiate a Vendor object of type Vendor|N/A|N/A| _True_ |
|2.|Vendor objects have a Name property assigned upon creation|N/A|N/A|_True_|
|3.|Vendor objects have a Description property assigned upon creation|N/A|N/A|_True_|
|4.|Vendor objects have a unique Id assigned upon creation|N/A|N/A|_True_  |
|5.|The program maintains a list of all instances of Vendor objects|N/A|N/A|_True_  |
|6.|The program can instantiate an Order object of type Order|N/A|N/A|_True_  |
|7.|Vendor objects contain a list of all orders associated with the vendor|N/A|N/A|_True_  |
|8.|Order objects are instantiated with a Title|N/A|N/A|_True_  |
|9.|Order objects are created with a Description property |N/A|N/A|_True_  |
|10.|Order objects contain a Price field upon creation |N/A|N/A|_True_  |
|11.|Order objects include a Date of Order field upon creation |N/A|N/A|_True_  |
|12.|Order objects include a unique Id which is assigned upon creation|N/A|N/A|_True_|
|13.|Order objects contain a list of all instantiated order objects|N/A|N/A|_True_|
|14.|The program will be able to find a Vendor object via its Id|N/A|N/A|_True_  |
|15.|The program will be able to find an Order object via its id|N/A|N/A|_True_  |
|16.|The program will be able to edit a Vendor objects values|Update Vendor Name: Charles Barkley|New Name: Paul Rudd|_True_|
|17.|The program will be able to update an Order objects values|Update Price: $15.00|New Price: $26.00|_True_|
|18.|The program will be able to delete Vendor objects|Delete Vendor: Alex Trebeck|Alex Trebeck Deleted|_True_|
|19.|The program will be able to delete Order objects|Delete Order|Order Deleted|_True_  |
|20.|The program can remove an Order from a Vendor list  |N/A|N/A|_True_  |
|21.|The program will display a list of clients each of which will have an order history|N/A|N/A|_True_  |
|22.|The program will also include an extension of the Vendor class, which will be a Client class, and contain all aspects of the Vendor class|N/A|N/A|_False_  |
|23.|The main splash page will present a total expenditures vs incoming funds|N/A|N/A|_False_  |

## Setup/Installation Requirements

1. This program utilizes .NET version 3.1, and requires this framework to be pre-installed:
    * Please go to https://dotnet.microsoft.com/download/dotnet-core/2.2 and install the SDK   version 2.2 or greater patch version, but do not upgrade to a higher minor version number.
2. Clone this repository onto your computer: https://github.com/...
3. In your preferred terminal window, navigate into PROJECTNAME.SOLUTIONS/PROJECTNAME using cd (i.e. cd desktop/PROJECTNAME.SOLUTIONS/PROJECTNAME) and open the project with your preferred code editor.
4. Run the following terminal command: $ dotnet restore
5. To initiate this program, run the command: $ dotnet run
6. To run the test suite included with this project, within the terminal navigate into PROJECTNAME.TESTS and run the following commands:
    * $ dotnet restore
    * $ dotnet test


## Known Bugs

_Periodically the FindVendor() static method is not finding the correct vendor as intended. Originally I was having this method return null, but this was causing too many errors. Instead, it returns the most recently made non-deleted vendor. Additionally this program has not been styled, and not all stretch goals were accomplished. Additionally, Bootstrap seems to not be applying all html class title css stylings as expected (e.g., the vendor delete buttons are supposed to be red [class="btn-alert"]). Due to time constraints I have also not fully mapped out all user interface paths, to ensure that every desired/expected path is included on each page._

## Support and contact details

_If you would like to contribute to this project, report any bugs/issues, or just to chat because Ian is a really cool dude, please reach out to Ian's email at: chesnekov@gmail.com_

## Technologies Used

_This program utilizes dotnet core app 2.2, the Model View Controller web application structure, c#, HTML, MSTest, Razor, and RESTFUL api routing._

### License

_This software is licensed under the MIT license_

Copyright (c) 2020 **Ian Scott**.