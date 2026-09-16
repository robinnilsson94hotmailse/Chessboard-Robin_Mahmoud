
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

Vi båda ändrade i README-filen. Mahmoud gjorde sedan git add, git commit och git push, medan jag(robin) gjorde git add och git commit.
Sedan gjorde jag git pull, vilket skapade en merge conflict. Jag öppnade README-filen och kollade konflikten och såg både det jag hade ändrat och det Mahmoud hade ändrat.
Vid det här laget såg Mahmoud inte båda ändringarna.
Vi hade missuppfattat varandra, så jag ändrade tillbaka till vad jag trodde att det skulle stå. Sedan körde jag:
git add README.md
 git commit -m "Lös merge conflict"
 git push
Efter det körde Mahmoud git pull och fick det jag hade ändrat tillbaka till, vilket visade sig vara fel. Han ändrade därför README-filen igen och sedan gjorde jag en git pull för att få hans senaste ändring.
Det vi lärde oss: Vi lärde oss hur en merge conflict kan uppstå när två personer ändrar samma fil och hur man kan lösa konflikten manuellt och sedan synkronisera ändringarna med Git.


## Utvecklare

- Mahmoud Halbia
- Robin Nilsson