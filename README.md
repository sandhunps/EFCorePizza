# EFCorePizza

This is a simple console aaplication to undestarnd code first migrations uinsg EF Core

CLI Commands

    - Create a new console application
         dotnet new console -n <Name of Application>
    
    - Add EF core code globally (This is a one time setup and if you have done this alredy, feel free to skip)
         dotnet tool install --global dotnet-ef

    - Add Initila Migrations
         dotnet ef nigrations add InitailCreate
    
    - Apply migrations to database
         dotnet ef database update
