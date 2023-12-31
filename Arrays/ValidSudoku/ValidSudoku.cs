namespace LeetCodeChallenge;

// 36. https://leetcode.com/problems/valid-sudoku/
public class ValidSudoku
{
    private const int Size = 9;
    private const char Empty = '.';

    public static bool IsValidSudoku(char[][] board)
    {
        HashSet<char> setRow = new();
        HashSet<char> setCol = new();
        HashSet<char> setSquare = new();
        
        for (int y = 0; y < Size; y++)
        {
            for (int x = 0; x < Size; x++)
            {
                char valueRow = board[y][x];
                char valueCol = board[x][y];

                // Check rows and columns
                if ((valueRow != Empty && setRow.Contains(valueRow)) || (valueCol != Empty && setCol.Contains(valueCol)))
                {
                    return false;
                }

                setRow.Add(valueRow);
                setCol.Add(valueCol);

                // Check boxes
                if (x % 3 == 0 && y % 3 == 0)
                {
                    if (!IsValidSquare(board, y, x, setSquare))
                    {
                        return false;
                    }
                }
            }

            setRow.Clear();
            setCol.Clear();
        }

        return true;
    }

    private static bool IsValidSquare(char[][] board, int startRow, int startCol, HashSet<char> set)
    {
        for (int row = startRow; row < startRow + 3; row++)
        {
            for (int col = startCol; col < startCol + 3; col++)
            {
                char value = board[row][col];

                if (value == Empty)
                {
                    continue;
                }

                if (set.Contains(value))
                {
                    return false;
                }

                set.Add(value);
            }
        }

        set.Clear();
        return true;
    }
}
