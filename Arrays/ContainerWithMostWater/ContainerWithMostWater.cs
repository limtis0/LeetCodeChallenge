namespace LeetCodeChallenge;

// 11. https://leetcode.com/problems/container-with-most-water/
public class ContainerWithMostWater
{
    public static int MaxArea(int[] height)
    {
        int p1 = 0;
        int p2 = height.Length - 1;
        int maxArea = 0;

        while (p1 < p2)
        {
            int currentArea = Math.Min(height[p1], height[p2]) * (p2 - p1);
            maxArea = Math.Max(maxArea, currentArea);

            if (height[p2] > height[p1])
            {
                p1++;
            }
            else
            {
                p2--;
            }
        }

        return maxArea;
    }
}
