namespace LeetCodeChallenge;

// 1679. https://leetcode.com/problems/max-number-of-k-sum-pairs/
public class MaxNumberOfKSumPairs
{
    public static int MaxOperations(int[] nums, int k)
    {
        Dictionary<int, int> savedNumbers = new();

        int count = 0;

        foreach (int num in nums)
        {
            int neededNum = k - num;
            
            savedNumbers.TryGetValue(neededNum, out int neededCount);
            
            if (neededCount == 0)
            {
                savedNumbers.TryGetValue(num, out int savedCount);
                savedNumbers[num] = savedCount + 1;
            }
            else
            {
                savedNumbers[neededNum]--;
                count++;
            }
        }

        return count;
    }
}
