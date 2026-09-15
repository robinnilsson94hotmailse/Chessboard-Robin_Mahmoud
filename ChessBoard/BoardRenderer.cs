internal class BoardRenderer
{
    public void RenderBoard(int size)
    {
        for (int row = 0; row < size; row++)
        {
            for (int column = 0; column < size; column++)
            {
                bool isDark = IsDarkSquare(row, column);

                Console.Write(isDark ? "◼︎" : "◻︎");
            }

            Console.WriteLine();
        }
    }

    private bool IsDarkSquare(int row, int column)
    {
        return (row + column) % 2 != 0;
    }
}