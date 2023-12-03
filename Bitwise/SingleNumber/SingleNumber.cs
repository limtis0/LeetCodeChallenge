namespace LeetCodeChallenge;

// 136. https://leetcode.com/problems/single-number/
public class SingleNumber
{
    public static int Find(int[] nums)
    {
        int num = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            num ^= nums[i];
        }

        return num;
    }
}
