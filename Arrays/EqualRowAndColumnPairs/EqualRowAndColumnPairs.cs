namespace LeetCodeChallenge;

// 2352. https://leetcode.com/problems/equal-row-and-column-pairs/
public class EqualRowAndColumnPairs
{
    public static int EqualPairs(int[][] grid)
    {
        Dictionary<string, int> rows = new();

        // Populate a HashSet
        foreach (int[] row in grid)
        {
            string rowString = string.Join(" ", row);
            rows[rowString] = rows.GetValueOrDefault(rowString) + 1;
        }

        // Count all pairs
        int count = 0;

        for (int col = 0; col < grid.Length; col++)
        {
            var column = Enumerable.Range(0, grid.Length).Select(x => grid[x][col]);
            string colString = string.Join(" ", column);

            if (rows.ContainsKey(colString))
            {
                count += rows[colString];
            }
        }

        return count;
    }
}
