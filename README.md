# WebShop-Example

WebShop-Example is ASP.NET Core 3.1 Web Api that uses MySQL Datatbase as data storage

## Congure MySQL Database

1. Download MySQL Server (and Workbanch) from https://dev.mysql.com/downloads/installer/
2. Open **WebShop-Example** project in Microsoft Visual Studio
3. Open **Package Manager Console** in Visual Studio (Tools -> NuGet Package Manager -> Package Manager Console)
4. Run next comands:
   - **add-migration _\<migration name\>_** - Creates a new migration class as per specified name
   - **update-database** - Executes the last migration file created by the **add-migration** command and applies changes to the database schema
