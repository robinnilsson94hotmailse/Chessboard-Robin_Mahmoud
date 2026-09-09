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

    Console.WriteLine("Invalid input. Please enter a number from 3 to 50.");
}

Console.WriteLine($"Board size: {boardSize} x {boardSize}");