namespace LeetCodeChallenge;

// 48. https://leetcode.com/problems/rotate-image/
public class RotateImage
{
    public static void Rotate(int[][] matrix)
    {
        (int height, int width) = (matrix.Length, matrix[0].Length);

        // Transpose
        for (int row = 0; row < height - 1; row++)
        {
            for (int col = row + 1; col < width; col++)
            {
                (matrix[col][row], matrix[row][col]) = (matrix[row][col], matrix[col][row]);
            }
        }

        // Mirror
        int centerCol = width / 2;

        for (int col = 0; col < centerCol; col++)
        {
            int oppositeCol = width - 1 - col;

            for (int row = 0; row < height; row++)
            {
                (matrix[row][col], matrix[row][oppositeCol]) = (matrix[row][oppositeCol], matrix[row][col]);
            }
        }
    }
}
