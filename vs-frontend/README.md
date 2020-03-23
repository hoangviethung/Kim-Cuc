- Configuration steps:
1. Open file MainProject.csproj
2. Choose File -> Save MainProject.sln in the same location
3. Use Ctrl + F5 to run source
3.1. If project can't be run, please expand Reference and check it is invalid library in Solution Explorer
3.2. To fix invalid, enter this command "Update-Package -reinstall" to Tools -> Nuget Package Manager -> Package Manager Console
4. Before commit source please turn off visual studio and choose "save" if any question's appeared.

- Views Folder is the main
- ViewsReadMe is explaination