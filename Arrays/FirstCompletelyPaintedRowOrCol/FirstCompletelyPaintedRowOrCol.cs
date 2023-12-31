namespace LeetCodeChallenge;

// 2661. https://leetcode.com/problems/first-completely-painted-row-or-column/
public class FirstCompletelyPaintedRowOrCol
{
    public static int FirstCompleteIndex(int[] arr, int[][] mat)
    {
        (int nRows, int nCols) = (mat.Length, mat[0].Length);

        Dictionary<int, (int row, int col)> valueToIndex = new();

        // Fill in the HashMap
        for (int r = 0; r < nRows; r++)
        {
            for (int c = 0; c < nCols; c++)
            {
                valueToIndex[mat[r][c]] = (r, c);
            }
        }
        
        int[] rowsFilled = new int[nRows];
        int[] colsFilled = new int[nCols];

        for (int i = 0; i < arr.Length; i++)
        {
            var (row, col) = valueToIndex[arr[i]];

            if (++rowsFilled[row] == nCols || ++colsFilled[col] == nRows)
            {
                return i;
            }
        }

        return -1;
    }
}
