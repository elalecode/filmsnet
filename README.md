# filmsnet
A web app to search films by title, actor or genre.

# Requirements
- .Net core 8
- Node > 17.0
- [EntityFrameworkCore.Design](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Design/9.0.0-preview.1.24081.2)
- Database credentials to MSQLServer instance

# Getting started
First one, download the repository.
```bash
git clone https://github.com/elalecode/filmsnet.git
```

Update the file `appsettings.Development.json` with the databes credentials, replace `[SERVER]`, `[DATABASE]`, `[USER]` and `[PASSWORD]` into `DefaultConnection` property:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=[SERVER];Initial Catalog=[DATABASE];user id=[USER];password=[PASSWORD];TrustServerCertificate=true"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  }
}
```

Then, open a terminal and run the follow command to create the tables and populate it:
```bash
dotnet ef database update
```

Finally, open the solution with Visual Studio and start the solution and enjoy searching films.
