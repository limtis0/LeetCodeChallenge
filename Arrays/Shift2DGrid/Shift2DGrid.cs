namespace LeetCodeChallenge;

// 1260. https://leetcode.com/problems/shift-2d-grid/
public class Shift2DGrid
{
    public static IList<IList<int>> ShiftGrid(int[][] grid, int k)
    {
        (int nRows, int nCols) = (grid.Length, grid[0].Length);

        int totalSize = nRows * nCols;

        // Skip unnecessary shifting
        k %= totalSize;

        // Initialize the result
        List<IList<int>> result = new();

        for (int row = 0; row < nRows; row++)
        {
            result.Add(new int[nCols]);
        }

        // Find shifted 1D index and map to 2D array
        for (int row = 0; row < nRows; row++)
        {
            for (int col = 0; col < nCols; col++)
            {
                int flatIndex = (row * nCols + col + k) % totalSize;

                (int shiftRow, int shiftCol) = Math.DivRem(flatIndex, nCols);

                result[shiftRow][shiftCol] = grid[row][col];
            }
        }

        return result;
    }

    public static IList<IList<int>> ShiftGridDeque(int[][] grid, int k)
    {
        (int nRows, int nCols) = (grid.Length, grid[0].Length);

        // Skip unnecessary shifting
        k %= nRows * nCols;

        // Initialize and fill-in the queue
        LinkedList<int> deque = new();

        for (int row = 0; row < nRows; row++)
        {
            for (int col = 0; col < nCols; col++)
            {
                deque.AddLast(grid[row][col]);
            }
        }

        // Shift the queue by k
        for (int i = 0; i < k; i++)
        {
            deque.AddFirst(deque.Last());
            deque.RemoveLast();
        }

        // Initialize and fill-in the result
        List<IList<int>> result = new();

        for (int row = 0; row < nRows; row++)
        {
            List<int> currentRow = new();

            for (int col = 0; col < nCols; col++)
            {
                currentRow.Add(deque.First());
                deque.RemoveFirst();
            }

            result.Add(currentRow);
        }

        return result;
    }
}
