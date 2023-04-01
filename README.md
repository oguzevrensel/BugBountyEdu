# BugBountyEdu
This project is created for educational purposes within the BugBounty startup community. 

# Technologies Used
 => .NET 6 <br>
 => ASP.NET Core <br>
 => Entity Framework Core <br>
 => Microsoft SQL Server <br>
## To run the project, follow these steps:

Clone the project repository to your local machine.
<br>
## Open the appsettings.json file and update the SQL Server connection string with your own SQL Server credentials.

```c#

"ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=BugBountyDb;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```
<br>
 Navigate to the project directory and run the following command:

```arduino
dotnet run
```
<br>
=> Open your web browser and navigate to http://localhost:5000 to confirm that the project is running.



