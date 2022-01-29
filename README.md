# Informacje ogólne
## Cars Board
Aplikacja webowa służąca do wystawiania aut na sprzedaż w postaci prostych ogłoszeń. Każde auto zawiera szczegółowe informacje na jego temat, co zdecydowanie ułatwi i umili zakup kupującemu :)

## Opis techniczny
* Target Framweork .NET(5.0)
* Architektura aplikacji oparta o wzorzec projektowy MVC
* Dynamiczne widoki tworzone z pomocą Razora
* System autoryzacji z wykorzystaniem [Identity](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity?view=aspnetcore-6.0&tabs=visual-studio)
* Baza danych oparta o [Entity Framework](https://docs.microsoft.com/en-us/ef/)
* W celu umożliwienia zewnętrznej integracji z naszym serwisem, udostępnione również zostało REST API
* Baza danych - SQLite

# Uruchomienie
## MACOS/LINUX
```
$ brew install dotnet
$ dotnet tool install --global dotnet-ef
$ dotnet ef database update
```
## Windows

Instalacja paczek za pomocą menagera NuGet lub wiersza poleceń według schematu:

```
Install-Package Nazwa_Biblioteki -version 5.0
Update-Database
```

# Lista blibliotek:
```
Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore 5.0.10
Microsoft.AspNetCore.Identity.EntityFrameworkCore 5.0.10
Microsoft.AspNetCore.Identity.UI 5.0.10
Microsoft.EntityFrameworkCore.Design 5.0.12
Microsoft.EntityFrameworkCore.Sqlite 5.0.10
Microsoft.EntityFrameworkCore.SqlServer 5.0.12
Microsoft.EntityFrameworkCore.Tools 5.0.10
Microsoft.VisualStudio.Web.CodeGeneration.Design 5.0.2
```

