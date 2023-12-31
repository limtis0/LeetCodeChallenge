namespace LeetCodeChallenge;

// 1582. https://leetcode.com/problems/special-positions-in-a-binary-matrix/
public class SpecialPositionInBinMatrix
{
    public static int NumSpecial(int[][] mat)
    {
        (int height, int width) = (mat.Length, mat[0].Length);

        int[] rowSum = new int[height];
        int[] indexOfOneInRow = new int[height];
        int[] colSum = new int[width];

        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if (mat[row][col] == 1)
                {
                    rowSum[row]++;
                    indexOfOneInRow[row] = col;
                    colSum[col]++;
                }
            }
        }

        int count = 0;

        for (int row = 0; row < height; row++)
        {
            if (rowSum[row] == 1 && colSum[indexOfOneInRow[row]] == 1)
            {
                count++;
            }
        }

        return count;
    }

    public static int NumSpecialTwoPass(int[][] mat)
    {
        (int height, int width) = (mat.Length, mat[0].Length);

        int[] rowSum = new int[height];
        int[] colSum = new int[width];

        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if (mat[row][col] == 1)
                {
                    rowSum[row]++;
                    colSum[col]++;
                }
            }
        }

        int count = 0;

        for (int row = 0; row < height; row++)
        {
            if (rowSum[row] != 1)
            {
                continue;
            }

            for (int col = 0; col < width; col++)
            {
                if (mat[row][col] == 1 && colSum[col] == 1)
                {
                    count++;
                }
            }
        }

        return count;
    }
}
