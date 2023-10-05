#  _Salon Management_

#### By _**Brian Yoder**_

#### _Manage stylists and clients using a one to many relationship in an ASP.NET Core MVC app using EntityFrameWorkCore!_

## Technologies Used

* MacBook Pro (13-inch, M1, 2020), macOS Ventura v. 13.4
* VSCode v. 1.76.1
* C#
* ASP.NET Core MVC
* Razor 
* Entity Framework Core
* MySql Workbench
* 

## Setup / Installation Requirements / Configuration

* Open Terminal/Command line
* Navigate to the desktop by typing **cd ~/Desktop** and press Enter on the keybord
* type **git clone https://github.com/brnydr/Salon.Solution** into the terminal and press Enter on the keyboard
* Navigate to the desktop and click on the "Salon.Solution" folder.
* Open the folder in VS Code


## Adding Packages

* In the terminal, navigate to "Salon" folder by using the following command: $ cd Salon
* Next, we'll add 2 essential packages using the following commands
  - $ dotnet add package Microsoft.EntityFramework -v 6.0.0
* Once the above has installed, enter this one next:
  - $ dotnet add package Pomelo.EntityFramework -v 6.0.0
* That's it for this part!

## Setting up appsettings.json
* In the terminal navigate to the project directory "Salon".
* Next, will add the file. In the terminal, enter the following:
  - $ touch appsettings.json
* Open the file in the code editor, and enter the following:
  ```json
  {
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR DATABASE NAME];uid=[YOUR USER ID];pwd=[YOUR PASSWORD];"
    }
  } 
  ```
* Save! Done!

## Importing the database schema

* First, open MySqlWorkbench
* In the Navigator > Administration window, select Data Import/Restore.
* In Import Options select Import from Self-Contained File.
* Navigate to 'brian_yoder.sql' at the root level of the project directory
* Under 'Default Schema to be Imported To', select the New button.
* Type the name you'd like to call the imported file
* Click Ok.
* Navigate to the tab called Import Progress and click Start Import at the bottom right corner of the window.
* After these steps are finished,  reopen the Navigator > Schemas tab: right click, and select Refresh All. 
* The database is now available, and the program is ready to run.

## Running the program
* In the terminal, navigate to the Salon folder
* Next, type this in the terminal:
  - $ dotnet run
* The program is ready to run on localhost. 

## Known Bugs

* None

## [License](https://mit-license.org/)

_If there are any issues found with the site, feel free to contact me at_ [brianyoder@gmail.com](brianyoder@gmail.com)

Copyright (c) _2023_ _Brian Yoder_