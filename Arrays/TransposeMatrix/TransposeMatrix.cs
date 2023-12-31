namespace LeetCodeChallenge;

// 867. https://leetcode.com/problems/transpose-matrix/
public class TransposeMatrix
{
    public static int[][] Transpose(int[][] matrix)
    {
        // Column and row count of TRANSPOSED matrix
        int cols = matrix.Length;
        int rows = matrix[0].Length;

        int[][] transposed = new int[rows][];

        for (int row = 0; row < rows; row++)
        {
            transposed[row] = new int[cols];

            for (int col = 0; col < cols; col++)
            {
                transposed[row][col] = matrix[col][row];
            }
        }

        return transposed;
    }
}
