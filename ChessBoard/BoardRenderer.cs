internal class BoardRenderer
{
    private const string WhiteSquare = "\u25A1"; // □
    private const string BlackSquare = "\u25A0"; // ■

    public void RenderBoard(int size)
    {
        for (int row = 0; row < size; row++)
        {
            for (int column = 0; column < size; column++)
            {
                bool isDark = IsDarkSquare(row, column);

                Console.Write(isDark
                    ? BlackSquare + " "
                    : WhiteSquare + " ");
            }

            Console.WriteLine();
        }
    }

    private bool IsDarkSquare(int row, int column)
    {
        return (row + column) % 2 != 0;
    }
}