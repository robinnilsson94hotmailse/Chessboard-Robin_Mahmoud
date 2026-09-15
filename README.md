
# Chessboard – Robin & Mahmoud

Ett C#-program som skapar ett schackbräde i konsolen.  
Användaren väljer brädets storlek mellan 3 och 50.

## Krav

För att köra projektet behöver du:

- .NET 10 SDK
- Git

Kontrollera .NET-versionen:

```powershell
dotnet --version
```

## Klona och köra projektet

Klona projektet från GitHub:

```powershell
git clone https://github.com/robinnilsson94hotmailse/Chessboard-Robin_Mahmoud.git
```

Öppna projektmappen:

```powershell
cd Chessboard-Robin_Mahmoud\ChessBoard
```

Bygg projektet:

```powershell
dotnet build
```

Kör programmet:

```powershell
dotnet run
```

## Exempel

```text
ChessBoard Generator
Enter chessboard size (3-50): 4
Board size: 4 x 4

◻︎◼︎◻︎◼︎
◼︎◻︎◼︎◻︎
◻︎◼︎◻︎◼︎
◼︎◻︎◼︎◻︎
```

Om användaren skriver text eller ett nummer utanför 3–50 visas ett felmeddelande.

## NuGet-paket

Projektet använder NuGet-paketet `Spectre.Console`.

Paketet används för att visa rubriker, felmeddelanden och lyckade resultat med färger. Vi valde paketet för att göra konsolprogrammet tydligare och enklare att använda.

Installera paketet med:

```powershell
dotnet add package Spectre.Console
```

## Kodstruktur

### Program.cs

- Startar programmet.
- Läser användarens input.
- Kontrollerar att input är ett heltal mellan 3 och 50.
- Skapar ett `BoardRenderer`-objekt.
- Anropar metoden som skriver ut schackbrädet.

### BoardRenderer.cs

Klassen ansvarar för att skapa och skriva ut schackbrädet.

- `RenderBoard(int size)` skriver ut alla rader och kolumner.
- `IsDarkSquare(int row, int column)` avgör om en ruta ska vara svart eller vit.

## Tekniska val

Vi använder `int.TryParse()` för att kontrollera input utan att programmet kraschar.

Vi använder nästlade `for`-loopar eftersom schackbrädet består av rader och kolumner.

Uttrycket `(row + column) % 2` används för att växla mellan svarta och vita rutor.

Koden är uppdelad i `Program.cs` och `BoardRenderer.cs` för att göra programmet lättare att läsa, testa och förklara.

## Git och samarbete

Projektet utvecklas av Mahmoud och Robin i ett gemensamt GitHub-repository.

Vi arbetar med:

- Separata branches för nya funktioner.
- Tydliga commits.
- Push till GitHub.
- Pull requests innan kod slås ihop med `main`.

### Merge conflict

Den här delen uppdateras efter att vi har skapat och löst vår merge conflict.

## Utvecklare

- Mahmoud Halbia
- Robin Nilsson