namespace LeetCodeChallenge;

// 1637. https://leetcode.com/problems/widest-vertical-area-between-two-points-containing-no-points/
public class WidestVerticalArea
{
    public static int MaxWidthOfVerticalArea(int[][] points)
    {
        int[][] ordered = points.OrderBy(p => p[0]).ToArray();
        int maxDistance = 0;

        for (int i = 1; i < ordered.Length; i++)
        {
            maxDistance = Math.Max(maxDistance, ordered[i][0] - ordered[i - 1][0]);
        }

        return maxDistance;
    }

    public static int MaxWidthOfVerticalAreaWithRBTree(int[][] points)
    {
        SortedSet<int> set = new();

        // O(n * log(n)) populating the set, it removes the duplicates while sorting the array
        foreach (int[] point in points)
        {
            set.Add(point[0]);
        }

        // Array for O(1) access
        int[] ordered = set.ToArray();

        int maxDistance = 0;
        for (int i = 1; i < set.Count; i++)
        {
            maxDistance = Math.Max(maxDistance, ordered[i] - ordered[i - 1]);
        }

        return maxDistance;
    }
}
