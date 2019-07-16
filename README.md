# MVCefProject

------------------------------------------------------------------------------------------------------------------------------
 dotnet ef migrations add InitialCreate  =>  Startup project 'Catalog.DataAccess.csproj' targets framework '.NETStandard'. There is no runtime associated with this framework, and projects targeting it cannot be executed directly. To use the Entity Framework Core .NET Command-line Tools with this project, add an executable project targeting .NET Core or .NET Framework that references this project, and set it as the startup project using --startup-project; or, update this project to cross-target .NET Core or .NET Framework. For more information on using the EF Core Tools with .NET Standard projects, see https://go.microsoft.com/fwlink/?linkid=2034781
 
 Cover project to core
 
------------------------------------------------------------------------------------------------------------------------------

dotnet ef migrations add InitialCreate  => Your startup project 'Catalog.DataAccess' doesn't reference Microsoft.EntityFrameworkCore.Design. This package is required for the Entity Framework Core Tools to work. Ensure your startup project is correct, install the package, and try again.

install package Microsoft.EntityFrameworkCore.Design to DataAccess project

------------------------------------------------------------------------------------------------------------------------------
 dotnet ef migrations add InitialCreate  => System.InvalidOperationException: No database provider has been configured for this DbContext. A provider can be configured by overriding the DbContext.OnConfiguring method or by using AddDbContext on the application service provider. If AddDbContext is used, then also ensure that your DbContext type accepts a DbContextOptions<TContext> object in its constructor and passes it to the base constructor for DbContext.
  ::Error::
 No database provider has been configured for this DbContext. A provider can be configured by overriding the DbContext.OnConfiguring method or by using AddDbContext on the application service provider. If AddDbContext is used, then also ensure that your DbContext type accepts a DbContextOptions<TContext> object in its constructor and passes it to the base constructor for DbContext.
  
  override OnConfiguring method with this
  
   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseMySQL(@"Server=localhost;Database=CampTest;User=root;Password=47854785zZ.;");
            base.OnConfiguring(optionsBuilder);

        }
        
        
++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

dotnet ef migrations add InitialCaner => Done. To undo this action, use 'ef migrations remove' 👌👌👌👌

------------------------------------------------------------------------------------------------------------------------------
dotnet ef database update => Failed executing DbCommand (18ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
SELECT `MigrationId`, `ProductVersion`
FROM `__EFMigrationsHistory`
ORDER BY `MigrationId`;

:error: Table 'camptest.__efmigrationshistory' doesn't exist

open your db shell and run this script

CREATE TABLE `__EFMigrationsHistory` ( `MigrationId` nvarchar(150) NOT NULL, `ProductVersion` nvarchar(32) NOT NULL, PRIMARY KEY (`MigrationId`) );
------------------------------------------------------------------------------------------------------------------------------
