
using Spectre.Console;

Console.OutputEncoding = System.Text.Encoding.UTF8;

AnsiConsole.MarkupLine("[bold blue]ChessBoard Generator[/]");

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