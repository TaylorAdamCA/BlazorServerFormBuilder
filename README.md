# Blazor Form Builder
A simple HTML form builder I built using ASP.NET Core Blazor, Entity Framework Core, and SQLServer. 
It uses dependency injection via the IoC framework, as well it follows the Services/Repository/Unit Of Work patterns (Repository and UoW are implemented by EFCore).

 

# Instructions
1. Clone the repo
2. Launch the solutions with Visual Studio 2017 or 2019
3. Open package manage console via Tools -> NuGet Package Manager -> Package manager console
4. Type "Add-Migration Initial" and hit enter
5. Once that has finished type “Update-Database” and hit enter to build the database
6. Run the solution using IIS Express 

# Plans for the future
- Make the forms submit and save the data to the database
- Add other input types like radio buttons that would use a list of values
- Possibly add an API so it follows more of an MVC pattern, but since it's all on the server anyways it might be redundant and unnecessary
- Update the UI to make it look and feel better

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details


