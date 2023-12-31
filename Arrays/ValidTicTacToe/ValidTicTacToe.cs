namespace LeetCodeChallenge;

// 794. https://leetcode.com/problems/valid-tic-tac-toe-state/
public class ValidTicTacToe
{
    private const int BoardSize = 3;

    public static bool IsValid(string[] board)
    {
        bool winX = false;
        bool winO = false;

        int countX = 0;
        int countO = 0;

        for (int i = 0; i < BoardSize; i++)
        {
            CheckRow(i, ref winX, ref winO, board);
            CheckColumn(i, ref winX, ref winO, board);

            foreach (char c in board[i])
            {
                if (c == 'X')
                {
                    countX++;
                }
                else if (c == 'O')
                {
                    countO++;
                }
            }
        }

        CheckDiagonals(ref winX, ref winO, board);

        // Two players can't win at the same time
        if (winX && winO)
        {
            return false;
        }

        int difference = countX - countO;

        // If X wins, difference must be exactly 1
        if (winX)
        {
            if (difference != 1)
            {
                return false;
            }
        }

        // If O wins, difference must be exactly 0
        if (winO)
        {
            if (difference != 0)
            {
                return false;
            }
        }

        // Else, difference is either 0 or 1
        if (difference != 0 && difference != 1)
        {
            return false;
        }

        return true;
    }

    private static void CheckRow(int row, ref bool winX, ref bool winO, string[] board)
    {
        if (board[row] == "XXX")
        {
            winX = true;
        }
        else if (board[row] == "OOO")
        {
            winO = true;
        }
    }

    private static void CheckColumn(int col, ref bool winX, ref bool winO, string[] board)
    {
        // Check cols for wins
        char colValue = board[0][col];

        if (colValue == ' ')
        {
            return;
        }

        if (board[1][col] == colValue && board[2][col] == colValue)
        {
            if (colValue == 'X')
            {
                winX = true;
            }
            else
            {
                winO = true;
            }
        }
    }

    private static void CheckDiagonals(ref bool winX, ref bool winO, string[] board)
    {
        char centerValue = board[1][1];

        if (centerValue != ' ')
        {
            if (
                (board[0][0] == centerValue && board[2][2] == centerValue)
                || board[0][2] == centerValue && board[2][0] == centerValue
            )
            {
                if (centerValue == 'X')
                {
                    winX = true;
                }
                else
                {
                    winO = true;
                }
            }
        }
    }
}
