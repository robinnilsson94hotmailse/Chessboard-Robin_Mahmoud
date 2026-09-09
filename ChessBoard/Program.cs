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
Console.WriteLine();

for (int row = 0; row < boardSize; row++)
{
    for (int column = 0; column < boardSize; column++)
    {
        if ((row + column) % 2 == 0)
        {
            Console.Write(". ");
        }
        else
        {
            Console.Write("# ");
        }
    }

    Console.WriteLine();
}