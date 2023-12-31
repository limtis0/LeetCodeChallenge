namespace LeetCodeChallenge;

// 1219. https://leetcode.com/problems/path-with-maximum-gold/
public class PathWithMaximumGold
{
    private static readonly int[] dx = { 0, 1, 0, -1 };
    private static readonly int[] dy = { 1, 0, -1, 0 };

    public static int GetMaximumGold(int[][] grid)
    {
        (int height, int width) = (grid.Length, grid[0].Length);

        int DFS(int row, int col)
        {
            if (row < 0 || row >= height || col < 0 || col >= width || grid[row][col] == 0)
            {
                return 0;
            }

            int temp = grid[row][col];
            int maxGold = 0;

            // Temporarily set as 0 to mark cell as visited
            grid[row][col] = 0;

            for (int i = 0; i < 4; i++)
            {
                maxGold = Math.Max(maxGold, DFS(row + dx[i], col + dy[i]));
            }

            grid[row][col] = temp;

            return temp + maxGold;
        }

        int answer = 0;

        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if (grid[row][col] != 0)
                {
                    answer = Math.Max(answer, DFS(row, col));
                }
            }
        }

        return answer;
    }
}
