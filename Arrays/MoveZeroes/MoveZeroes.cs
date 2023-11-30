namespace LeetCodeChallenge;

// 283. https://leetcode.com/problems/move-zeroes/
public class MoveZeroes
{
    public static void Solution(int[] nums)
    {
        int p1 = 0;

        // Find the first non-zero index
        while (p1 < nums.Length && nums[p1] != 0)
        {
            p1++;
        }

        int p2 = p1 + 1;

        while (p2 < nums.Length)
        {
            if (nums[p2] != 0)
            {
                nums[p1] = nums[p2];
                nums[p2] = 0;
                p1++;
            }

            p2++;
        }
    }
}
