# Chessboard – Robin & Mahmoud

Ett C#-program som skapar ett schackbräde i konsolen. Användaren väljer brädets storlek mellan 3 och 50, och programmet skriver sedan ut ett bräde med växlande mörka och ljusa Unicode-rutor.

Projektet är utvecklat av Mahmoud Halbia och Robin Nilsson som en del av kursen *Introduktion till yrkesrollen och grunderna i C# och .NET*.

## Funktioner

- Tar emot en brädstorlek mellan 3 och 50.
- Kontrollerar användarens input med `int.TryParse()`.
- Visar ett tydligt felmeddelande vid ogiltig input.
- Skriver ut ett schackbräde med Unicode-symboler.
- Visar brädets storlek och det totala antalet rutor.
- Visar antalet mörka och ljusa rutor.
- Låter användaren skapa flera bräden utan att starta om programmet.
- Använder `Spectre.Console` för färger och interaktiva val.

## Krav

För att köra projektet behöver du:

- .NET 10 SDK
- Git
- En terminal med stöd för UTF-8 och Unicode

Kontrollera installerad .NET-version:

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

Återställ projektets NuGet-paket:

```powershell
dotnet restore
```

Bygg projektet:

```powershell
dotnet build
```

Kör programmet:

```powershell
dotnet run
```

## Exempel på användning

```text
■ ChessBoard Generator ■
Enter chessboard size (3-50): 5
Board size: 5 x 5

□ ■ □ ■ □
■ □ ■ □ ■
□ ■ □ ■ □
■ □ ■ □ ■
□ ■ □ ■ □

Board information:
Total squares: 25
Dark squares: 12
Light squares: 13

Do you want to create another board?
> Yes
  No
```

Om användaren skriver text, ett decimaltal eller ett heltal utanför intervallet 3–50 visas ett felmeddelande. Programmet fortsätter fråga tills användaren anger ett giltigt heltal.

Efter att brädet har skrivits ut kan användaren välja `Yes` för att skapa ett nytt bräde eller `No` för att avsluta programmet.

## NuGet-paket

Projektet använder NuGet-paketet [`Spectre.Console`](https://spectreconsole.net/).

Paketet används för att visa:

- färgade rubriker
- tydliga felmeddelanden
- information om brädet
- en interaktiv meny med alternativen `Yes` och `No`

Vi valde paketet för att göra konsolprogrammet tydligare, mer lättläst och enklare att använda.

Paketet kan installeras manuellt med:

```powershell
dotnet add package Spectre.Console
```

Paketreferensen finns redan i projektfilen och hämtas normalt automatiskt av `dotnet restore` eller `dotnet build`.

## Kodstruktur

### `Program.cs`

`Program.cs` ansvarar för programmets huvudsakliga flöde:

- ställer in UTF-8 för Unicode-symbolerna
- visar programmets rubrik
- läser användarens input
- kontrollerar att input är ett heltal mellan 3 och 50
- skapar ett objekt av klassen `BoardRenderer`
- anropar metoden som skriver ut schackbrädet
- beräknar antalet rutor
- frågar om användaren vill skapa ett nytt bräde

### `BoardRenderer.cs`

Klassen `BoardRenderer` ansvarar för att skapa och skriva ut schackbrädet.

- `RenderBoard(int size)` använder nästlade loopar för att skriva ut brädets rader och kolumner.
- `IsDarkSquare(int row, int column)` avgör om en ruta ska vara mörk eller ljus.

Genom att placera ritlogiken i en egen klass får `Program.cs` och `BoardRenderer.cs` tydliga och separata ansvarsområden.

## Tekniska val

### Input-validering

Vi använder `int.TryParse()` för att försöka omvandla användarens text till ett heltal. Metoden returnerar `false` vid ogiltig input i stället för att krascha programmet.

Programmet kontrollerar också att talet är mellan 3 och 50. En `while`-loop gör att användaren får försöka igen tills input är giltig.

### Rader och kolumner

Schackbrädet skapas med två nästlade `for`-loopar:

- den yttre loopen skapar raderna
- den inre loopen skapar kolumnerna

### Växlande rutor

Uttrycket `(row + column) % 2` används för att växla mellan mörka och ljusa rutor. Om resten efter division med två är noll är summan jämn. Annars är summan udda.

### Unicode och UTF-8

Brädet använder Unicode-symbolerna `□` och `■`. Programmet ställer in `Console.OutputEncoding` till UTF-8 för att terminalen ska kunna visa Unicode-symbolerna korrekt.

Hur symbolerna visas kan även bero på terminalens valda teckensnitt.

### Information om brädet

Det totala antalet rutor beräknas med:

```csharp
int totalSquares = boardSize * boardSize;
```

Antalet mörka och ljusa rutor beräknas utifrån det totala antalet. Beräkningen fungerar för både jämna och udda brädstorlekar.

### Skapa ett nytt bräde

Efter varje utskrift visar `Spectre.Console` en meny med `Yes` och `No`. Användarens val sparas i variabeln `answer`.

Om användaren väljer `Yes` fortsätter den yttre `while`-loopen. Om användaren väljer `No` avslutas loopen och programmet stängs.

## Git och samarbete

Projektet utvecklades av Mahmoud och Robin i ett gemensamt GitHub-repository.

Vi använde:

- separata branches för nya funktioner
- tydliga commits som beskrev varje ändring
- push till GitHub
- pull requests innan kod slogs ihop med `main`
- code review för att kontrollera varandras ändringar
- `git pull` för att hålla våra lokala versioner uppdaterade

Exempel på arbetsflöde:

```powershell
git switch main
git pull
git switch -c branch-name
git add .
git commit -m "Beskriv ändringen"
git push -u origin branch-name
```

## Merge conflict

Vi skapade och löste en merge conflict i `README.md`. Konflikten uppstod eftersom vi båda hade ändrat samma del av filen i olika lokala versioner.

Robin gjorde `git pull` efter att båda hade skapat egna ändringar. Git kunde inte automatiskt avgöra vilken text som skulle behållas och markerade därför konflikten i filen.

Vi öppnade `README.md`, jämförde båda versionerna och valde tillsammans vilket innehåll som skulle vara kvar. Därefter sparade vi den lösta versionen med:

```powershell
git add README.md
git commit -m "Resolve README merge conflict"
git push
```

Mahmoud hämtade sedan den uppdaterade versionen med `git pull`. När vi upptäckte att en del av texten fortfarande behövde rättas uppdaterade vi filen igen och synkroniserade båda datorerna.

Det vi lärde oss var:

- en merge conflict kan uppstå när två personer ändrar samma rader
- konflikten betyder inte att projektet är förstört
- Git behöver hjälp att välja eller kombinera innehållet
- tydlig kommunikation minskar risken för onödiga konflikter
- små och tydliga commits gör ändringar enklare att granska

## Utvecklare

- Mahmoud Halbia
- Robin Nilsson
