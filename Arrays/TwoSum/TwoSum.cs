namespace LeetCodeChallenge;

// 1. https://leetcode.com/problems/two-sum/
public class TwoSum
{
    public static int[] Solution(int[] nums, int target)
    {
        Dictionary<int, int> numIndex = new();

        for (int i = 0; i < nums.Length; i++)
        {
            int difference = target - nums[i];

            if (numIndex.ContainsKey(difference))
            {
                return new int[] { numIndex[difference], i };
            }
            else
            {
                numIndex[nums[i]] = i;
            }
        }

        return Array.Empty<int>();
    }
}
