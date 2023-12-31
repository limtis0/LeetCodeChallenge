namespace LeetCodeChallenge;

// 2482. https://leetcode.com/problems/difference-between-ones-and-zeros-in-row-and-column/
public class DifferenceBetweensOnesAndZeros
{
    // // Second variant, but pre-calculating the difference istead of ones
    // public static int[][] OnesMinusZeros(int[][] grid)
    // {
    //     (int height, int width) = (grid.Length, grid[0].Length);

    //     // Precalculate zeros for each row/col
    //     int[] rowDiff = new int[height];
    //     int[] colDiff = new int[width];

    //     for (int row = 0; row < height; row++)
    //     {
    //         for (int col = 0; col < width; col++)
    //         {
    //             int OneOrMinusOne = grid[row][col] * 2 - 1;  // Same as  grid[row][col] ?: -1;

    //             rowDiff[row] += OneOrMinusOne;
    //             colDiff[col] += OneOrMinusOne;
    //         }
    //     }

    //     // Fill in the difference
    //     int[][] difference = new int[height][];

    //     for (int row = 0; row < height; row++)
    //     {
    //         difference[row] = new int[width];

    //         for (int col = 0; col < width; col++)
    //         {
    //             difference[row][col] = rowDiff[row] + colDiff[col];
    //         }
    //     }

    //     return difference;
    // }

    public static int[][] OnesMinusZeros(int[][] grid)
    {
        (int height, int width) = (grid.Length, grid[0].Length);

        // Precalculate zeros for each row/col
        int[] rowOneCount = new int[height];
        int[] colOneCount = new int[width];

        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                rowOneCount[row] += grid[row][col];
                colOneCount[col] += grid[row][col];
            }
        }

        // Fill in the difference
        int[][] difference = new int[height][];

        for (int row = 0; row < height; row++)
        {
            difference[row] = new int[width];

            int rowDifference = (2 * rowOneCount[row]) - width;

            for (int col = 0; col < width; col++)
            {
                difference[row][col] = rowDifference + (2 * colOneCount[col]) - height;
            }
        }

        return difference;
    }
}
