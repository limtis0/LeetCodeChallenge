namespace LeetCodeChallenge;

// 2870. https://leetcode.com/problems/minimum-number-of-operations-to-make-array-empty/
public class MinOperationsToEmptyArray
{
    public static int MinOperations(int[] nums)
    {
        Dictionary<int, int> count = new();

        foreach (int num in nums)
        {            
            count[num] = count.GetValueOrDefault(num) + 1;
        }

        int totalOperations = 0;

        foreach (int num in count.Values)
        {
            if (num == 1)
            {
                return -1;
            }
            
            if (num % 3 == 0)
            {
                totalOperations += num / 3;
            }
            else
            {
                totalOperations += num / 3 + 1;
            }
        }

        return totalOperations;
    }
}
