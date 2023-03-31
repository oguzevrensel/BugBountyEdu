## BugBountyEdu
This project is created for educational purposes within the BugBounty startup community. 

## Technologies Used
.NET 6
ASP.NET Core
Entity Framework Core
Microsoft SQL Server
HTML, CSS, JavaScript
Bootstrap
Running the Project
To run the project, follow these steps:

Clone the project repository to your local machine.
<br>
# Open the appsettings.json file and update the SQL Server connection string with your own SQL Server credentials.

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
Open your web browser and navigate to http://localhost:5000 to confirm that the project is running.

Contributing to the Project
If you would like to contribute to the project, please follow these steps:

Fork this repository.

Make the desired changes and commit them.

Navigate to your forked repository and click on the "New Pull Request" button.

Write a title and description that describe your changes and click the Pull Request button.

Your changes will be reviewed and merged into the project if they are approved.

License
This project is licensed under the MIT license. For more information, please refer to the LICENSE file.
