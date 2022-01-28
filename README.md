# Informacje ogólne
## Cars Board
Aplikacja webowa służąca do wystawiania aut na sprzedaż w postaci prostych ogłoszeń. Każde auto zawiera szczegółowe informacje na jego temat, co zdecydowanie ułatwi i umili zakup kupującemu :)

## Opis techniczny
* Architektura aplikacji oparta o wzorzec projektowy MVC
* Dynamiczne widoki tworzone z pomocą Razora
* System autoryzacji z wykorzystaniem [Identity](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity?view=aspnetcore-6.0&tabs=visual-studio)
* Baza danych oparta o [Entity Framework](https://docs.microsoft.com/en-us/ef/)
* W celu umożliwienia zewnętrznej integracji z naszym serwisem, udostępnione również zostało REST API

# Uruchomienie
## MACOS/LINUX
```
$ brew install dotnet
$ dotnet tool install --global dotnet-ef
$ dotnet ef database update
```
