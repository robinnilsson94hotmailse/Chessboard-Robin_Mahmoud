using Spectre.Console;

Console.OutputEncoding = System.Text.Encoding.UTF8;

AnsiConsole.MarkupLine("[bold blue]ChessBoard Generator[/]");

bool runAgain = true;

while (runAgain)
{
    int boardSize;

    while (true)
    {
        Console.Write("Enter chessboard size (3-50): ");
        string? input = Console.ReadLine();

        if (int.TryParse(input, out boardSize) &&
            boardSize >= 3 &&
            boardSize <= 50)
        {
            break;
        }

        AnsiConsole.MarkupLine(
            "[bold red]Invalid input. Please enter a number from 3 to 50.[/]");
    }

    AnsiConsole.MarkupLine(
        $"[bold green]Board size: {boardSize} x {boardSize}[/]");

    Console.WriteLine();

    BoardRenderer renderer = new BoardRenderer();
    renderer.RenderBoard(boardSize);

    int totalSquares = boardSize * boardSize;
    int darkSquares = totalSquares / 2;
    int lightSquares = totalSquares - darkSquares;

    Console.WriteLine();

    AnsiConsole.MarkupLine("[bold yellow]Board information:[/]");
    AnsiConsole.MarkupLine($"Total squares: [bold]{totalSquares}[/]");
    AnsiConsole.MarkupLine(
        $"Dark squares: [bold grey]{darkSquares}[/]");
    AnsiConsole.MarkupLine(
        $"Light squares: [bold white]{lightSquares}[/]");

    Console.WriteLine();

    string answer = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
            .Title("[yellow]Do you want to create another board?[/]")
            .AddChoices("Yes", "No")
    );

    runAgain = answer == "Yes";

    Console.WriteLine();
}

AnsiConsole.MarkupLine(
    "[bold blue]Thank you for using ChessBoard Generator![/]");