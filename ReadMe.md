# migrations
========================================================================================
dotnet add package Microsoft.EntityFrameworkCore --version 7.0.1

dotnet add package Pomelo.EntityFrameworkCore.MySql --version 7.0.0-silver.1

dotnet add package Microsoft.EntityFrameworkCore.Tools

dotnet tool install --global dotnet-ef

dotnet ef migrations add MinhaMigracao

dotnet ef database update

dotnet watch run
=========================================================================================

# scaffold
=========================================================================================

dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design

dotnet add package Microsoft.EntityFrameworkCore.SqlServer

dotnet tool install -g dotnet-aspnet-codegenerator

dotnet aspnet-codegenerator controller -name LoginController -m Login -dc DbContexto --relativeFolderPath Controllers --useDefaultLayout
