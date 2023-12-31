namespace LeetCodeChallenge;

// 1266. https://leetcode.com/problems/minimum-time-visiting-all-points/
public class MinimumTimeVisitingPoints
{
    public static int Solution(int[][] points)
    {
        int seconds = 0;

        for (int i = 1; i < points.Length; i++)
        {
            seconds += TimeToTravel(points[i - 1], points[i]);
        }
        
        return seconds;
    }

    private static int TimeToTravel(int[] pointA, int[] pointB)
    {
        int timeX = Math.Abs(pointA[0] - pointB[0]);
        int timeY = Math.Abs(pointA[1] - pointB[1]);

        return Math.Max(timeX, timeY);
    }
}
