# JobLearning

JobLearning är ett lärande- och portfolioprojekt. Målet är att bygga en lärplattform där administratörer kan skapa kurser, tilldela dem till medarbetare och följa upp genomförandet.

## Nuläge

API:et är byggt med C#, ASP.NET Core och Entity Framework Core. Den första migrationen skapar tabellen `Courses` i SQL Server.

- `GET /api/courses` listar kurser.
- `POST /api/courses` validerar indata och sparar en ny kurs.

Nästa steg är att bygga kurskatalogen med React, TypeScript och Vite.

## Kör lokalt

Du behöver .NET 10 SDK och SQL Server Express LocalDB på Windows. Kör följande från repots rot i PowerShell.

```powershell
dotnet tool restore
Set-Location .\backend\JobLearning.Api
dotnet ef database update -- --environment Development
dotnet run
```

Öppna `/api/courses` på adressen som visas i terminalen. Använd fiktiva data vid lokal utveckling.
