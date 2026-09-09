int boardSize = ReadBoardSize();

Console.WriteLine($"Board size: {boardSize} x {boardSize}");

DrawBoard(boardSize);

static int ReadBoardSize()
{
    while (true)
    {
        Console.Write("Enter chessboard size (3-50): ");
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int boardSize) &&
            boardSize >= 3 &&
            boardSize <= 50)
        {
            return boardSize;
        }

        Console.WriteLine("Invalid input. Please enter a number from 3 to 50.");
    }
}

static void DrawBoard(int boardSize)
{
    Console.WriteLine();

    for (int row = 0; row < boardSize; row++)
    {
        for (int column = 0; column < boardSize; column++)
        {
            if ((row + column) % 2 == 0)
            {
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.White;
            }

            Console.Write("  ");
            Console.ResetColor();
        }

        Console.WriteLine();
    }
}