namespace LeetCodeChallenge;

// 55. https://leetcode.com/problems/jump-game/
public class JumpGame
{
    public static bool CanJump(int[] nums)
    {
        int furthest = nums[0];
        
        for (int i = 1; i < nums.Length; i++)
        {
            if (i > furthest)
            {
                return false;
            }

            furthest = Math.Max(furthest, i + nums[i]);
        }

        return true;
    }
}
