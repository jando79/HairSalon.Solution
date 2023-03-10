# _Hair Salon_

#### By _David Jandron_

#### _A C# web application using MySQL that creates a website for the owner of Eau Claire's Salon. This site allows the owner to view their employees, and the clients their employees have._

## Technologies Used

* _.Net 6_
* _ASP.NET Core MVC 6_
* _C#_
* _MYSQL_

## Description

_This is site built for users to enter new employess, search and display current employees, as well as clients assiciated with the specific type of employees. Controllers and multiple views directories are utilized for ease of navigation. We use MySql to allow users to store information in a database._

## Setup/Installation Requirements

* Clone this repo.
* Open the terminal and navigate to this project's production directory called "HairSalon.Solution".
* Within the production directory "HairSalon", create a new file called appsettings.json.
* Within appsettings.json, put in the following code.
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=david_jandron;uid=root;pwd=epicodus;"
  }
}
# Importing The Database

* Open MySQLWorkbench

* In the Navigator > Administration window, select Data Import/Restore.

* In Import Options select Import from Self-Contained File.

* Look for the "HairSalon.Solution" directory and pick the file called "DavidJandron.sql"

* Under Default Schema to be Imported To, select the New button.

* Enter the name of the name of the database: david_jandron

* Click Ok.

* Navigate to the tab called Import Progress and click Start Import at the bottom right corner of the window.

* After you are finished with the above steps, reopen the Navigator > Schemas tab. Right click and select Refresh All. The database will appear.

* Navigate back to VS Code, and within the production directory "HairSalon", run dotnet watch run in the command line to start the project in development mode with a watcher.

* Open the browser to https://localhost:5001.


## Known Bugs

* _Delete Functionality not working_

## License

_MIT License_

Copyright (c) _2023_ _authored by: David Jandron_