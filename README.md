# BusinessCommunicator - aplikacja webowa, portal z ogłoszeniami użytkowników oraz czat. 

Projekt oparty na frameworku .Net Core MVC. 
Biblioteki:
- Entity Framework
- SignalR


Projekt wstępnie przy wykorzysta bazę danych SQL Server z perspektywą wdorżenia rozwiązania chmurowego Azure 


Obiekty systemu:
- User:
  - Id
  - Name
  - Email
  - Password
  - Active

- Message:
  - Id
  - Description
  - UserId
  - Active
 
 
 Inteface:
 okno główne prezentujące okno z ogłoszeniami użytkowników oraz okno czatu
 karta dodatkowa będzie obsługiwać ogłoszenia danego użytkownika zgodnie z CRUD
 karta dodatkowa będzie odpowiedzialna za ustawienia użytkownika
 
