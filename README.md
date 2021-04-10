<p align="center"> Authored by Brian Sturgis</p>
<p align="center">Updated on April 3rd, 2021</p>

## Detailed Description
an API for a local business lookup. The API will list restaurants and shops in Portland Oregon.

### Known Bugs
-API Versioning in .Net Core was started but will not be offered in the applications current state.  See instructions for intended usage though down below under "versioning".

### Install .NET Core
* Confirm you have installed .NET installed - this will provide access to the C# language
  * [.NET for macOS](https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.100-macos-x64-installer)
  * [.NET for Windows](https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.102-windows-x64-installer)

### Install dotnet script
 Enter the command ``dotnet tool install -g dotnet-script`` in Terminal for macOS or PowerShell for Windows.

### Install MySQL Workbench
 [Download and install the appropriate version of MySQL Workbench](https://dev.mysql.com/downloads/workbench/).

### Install Postman
(Optional) [Download and install Postman](https://www.postman.com/downloads/).

### Code Editor
  To view or edit the code, you will need an code editor or text editor. The popular open-source choices for an code editor are Atom and VisualStudio Code.

  1) Code Editor Download:
     * Option 1: [Atom](https://nodejs.org/en/)
     * Option 2: [VisualStudio Code](https://www.npmjs.com/)
  2) Click the download most applicable to your OS and system.
  3) Wait for download to complete, then install -- Windows will run the setup exe and macOS will drag and drop into applications.
  4) Optionally, create a [GitHub Account](https://github.com)

### Installation
* Clone the repository with the following git terminal command: ```$ git clone https://github.com/BrianSturgis/JanWeek13Project.Solution.git```
* Open the project directory in your terminal
* Navigate to the ```Factory``` directory
    * To create ```obj``` directories in both production and test projects, run the terminal command: ```$ dotnet restore```
    * **NOTE**: Do not touch the code in either ```obj``` directory.
* To launch the program, run the terminal command: ```dotnet run```
(Ensure you are in the project's root directory, Factory, in your Terminal/CMD before running these commands.)

### AppSettings
  1) Create a new file in the JanWeek13Project.Solution/BusinessTrackerAPI directory named `appsettings.json`
  2) Add in the following code snippet to the new appsettings.json file:

  ```
{
    "Logging": {
        "LogLevel": {
        "Default": "Warning"
        }
    },
    "AllowedHosts": "*",
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=business_tracker;uid=root;pwd=[YourPassword];"
    }
}
  ```
  3) Change the server, port, and user id as necessary. Replace 'YourPassword' with relevant MySQL password (set at installation of MySQL).

### Database
  1) Navigate to JanWeek13Project.Solution/BusinessTrackerAPI directory using the MacOS Terminal or Windows Powershell (e.g. `cd Desktop/JanWeek13Project.Solution/BusinessTrackerAPI`).
  2) Run the command `dotnet ef database update` to generate the database through Entity Framework Core.
  3) (Optional) To update the database with any changes to the code, run the command `dotnet ef migrations add <MigrationsName>` which will use Entity Framework Core's code-first principle to generate a database update. After, run the previous command `dotnet ef database update` to update the database.

  ### Launch the API
  1) Navigate to JanWeek13Project.Solution/BusinessTrackerAPI directory using the MacOS Terminal or Windows Powershell (e.g. `cd DesktopJanWeek13Project.Solution/BusinessTrackerAPI`).
  2) Run the command `dotnet run` to have access to the API in Postman or browser.

## Endpoints
Base URL: `https://localhost:5000`

## HTTP Request Structure
GET /api/{component}
POST /api/{component}
GET /api/{component}/{id}
PUT /api/{component}/{id}
DELETE /api/{component}/{id}

#### Example Query
```
https://localhost:5000/api/businesses/1
```

#### Sample JSON Response
```
{
        "businessId": 1,
        "businessName": "Cafe Allora",
        "businessType": "Italian fusion",
        "businessAge": 19,
        "businessSeating": "in/out"
    }
```

### VERSIONING

This project was intended to have versioning capability using Microsoft.AspNetCore.Mvc.Versioning.
In the projects Home controller would look like this.
```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
 
namespace ApiVersioningSampleApp.Controllers
{
[ApiVersion("1.0")]   ------VERSION 1
[Route("api/Values")]
public class ValuesV1Controller : Controller
{
// GET api/values
[HttpGet]
public IEnumerable<string> Get()
{
return new string[] { "Value1 from Version 1", "value2 from Version 1" };
}
}
 
[ApiVersion("2.0")]  ------VERSION 2
[Route("api/Values")]
public class ValuesV2Controller : Controller
{
// GET api/values
[HttpGet]
public IEnumerable<string> Get()
{
return new string[] { "value1 from Version 2", "value2 from Version 2" };
}
}
}


```
- an attribute [ApiVersion(“1.0”)] for Version 1 is created.
- an attribute [ApiVersion(“2.0”)] for Version 2 is created.
- the Get value is changed to understand which version is getting called
- run the application and see the Version 1 API is getting because when we do not specify any specific version, default version (1.0 in our case) would be called:

### directions to see versions
specify in the query at the local host: /api/values?api-version=1.0 or /api/values?api-version=2.0
and receive ["value from version #", "value#"]
or 
you can change the route to [Route(“api/{v:apiVersion}/Values”)] then 
specify in the query at the local host:/api/2.0/values to receive ["value from version #", "value#"].



## Technologies Used
* C#
* NET
* VisualStudio Code
* Git
* GitHub
* MSTest
* coffee
* .NET 5
* ASP.NET Core
* Entity Framework
* MySQL Workbench 8.0.15
* Postman

### License
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE..

Copyright (c) 2020 **Brian Micheal Sturgis**