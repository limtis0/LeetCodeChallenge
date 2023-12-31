namespace LeetCodeChallenge;

// 417. https://leetcode.com/problems/pacific-atlantic-water-flow/
public class PacificAtlanticWaterFlow
{
    public static IList<IList<int>> PacificAtlantic(int[][] heights)
    {
        (int nRows, int nCols) = (heights.Length, heights[0].Length);

        void DFS(bool[,] canVisit, int row, int col, int prevValue = int.MinValue)
        {
            // Out-of-bounds
            if (row < 0 || col < 0 || row >= nRows || col >= nCols)
            {
                return;
            }

            // If already marked
            if (canVisit[row, col])
            {
                return;
            }

            int currentHeight = heights[row][col];

            // Can't visit as it is smaller than neighbour
            if (currentHeight < prevValue)
            {
                return;
            }

            canVisit[row, col] = true;

            // Mark adjacent cells
            for (int i = -1; i <= 1; i++)
            {
                DFS(canVisit, row + i, col, currentHeight);
                DFS(canVisit, row, col + i, currentHeight);
            }
        }

        bool[,] canVisitAtlantic = new bool[nRows, nCols];
        bool[,] canVisitPacific = new bool[nRows, nCols];

        // Mark vertical edges
        for (int r = 0; r < nRows; r++)
        {
            DFS(canVisitPacific, r, 0);
            DFS(canVisitAtlantic, r, nCols - 1);
        }

        // Mark horizontal edges
        for (int c = 0; c < nCols; c++)
        {
            DFS(canVisitPacific, 0, c);
            DFS(canVisitAtlantic, nRows - 1, c);
        }

        // Fill in the results
        List<IList<int>> result = new();

        for (int r = 0; r < nRows; r++)
        {
            for (int c = 0; c < nCols; c++)
            {
                if (canVisitAtlantic[r, c] && canVisitPacific[r, c])
                {
                    result.Add(new List<int>() { r, c });
                }
            }
        }

        return result;
    }
}
