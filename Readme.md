# _Pierres Order Tracker_

#### _A web application for listing, adding, and removing clients and their orders from lists_

#### By _**Ian Scott**_

## Description

_Long description._

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

|8.|Order objects are instantiated with a Title|N/A|N/A|_False_  |

|9.|Order objects are created with a Description property |N/A|N/A|_False_  |
|10.|Order objects contain a Price field upon creation |N/A|N/A|_False_  |
|11.|Order objects include a Date of Order field upon creation |N/A|N/A|_False_  |
|12.|Order objects include a unique Id which is assigned upon creation|N/A|N/A|_False_|

|13.|The program will be able to find a Vendor object via its Id|N/A|N/A|_False_  |
|14.|The program will be able to find an Order object via its id|N/A|N/A|_False_  |
|15.|The program will be able to edit a Vendor objects values|Update Vendor Name: Charles Barkley|New Name: Paul Rudd|_False_|
|16.|The program will be able to update an Order objects values|Update Price: $15.00|New Price: $26.00|_False_|

|17.|The program will be able to delete Vendor objects|Delete Vendor: Alex Trebeck|Alex Trebeck Deleted|_False_|
|18.|The program will be able to delete Order objects|Delete Order|Order Deleted|_False_  |

|19.|The program will also include an extension of the Vendor class, which will be a Client class, and contain all aspects of the Vendor class|N/A|N/A|_False_  |
|20.|The program will display a list of clients each of which will have an order history|N/A|N/A|_False_  |
|21.|The main splash page will present a total expenditures vs incoming funds|N/A|N/A|_False_  |

|3.|  |N/A|N/A|_False_  |

|3.|  |  |  |_False_  |

|3.|  |  |  |_False_  |
|3.|  |  |  |_False_  |
|3.|  |  |  |_False_  |
|3.|  |  |  |_False_  |
|3.|  |  |  |_False_  |
|3.|  |  |  |_False_  |

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

_There are currently no known bugs._

## Support and contact details

_If you would like to contribute to this project, report any bugs/issues, or just to chat because Ian is a really cool dude, please reach out to Ian's email at: chesnekov@gmail.com_

## Technologies Used

- C#
- .NET

### License

_This software is licensed under the MIT license_

Copyright (c) 2020 **Ian Scott**.