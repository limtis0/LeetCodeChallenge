namespace LeetCodeChallenge;

// 334. https://leetcode.com/problems/increasing-triplet-subsequence/
public class TripletSubsequence
{
    public static bool Exists(int[] nums)
    {
        if (nums.Length < 3)
        {
            return false;
        }

        int first = int.MaxValue;
        int second = int.MaxValue;

        foreach (int current in nums)
        {
            if (current <= first)
            {
                first = current;
            }
            else if (current <= second)
            {
                second = current;
            }
            else
            {
                return true;
            }
        }

        return false;
    }
}
