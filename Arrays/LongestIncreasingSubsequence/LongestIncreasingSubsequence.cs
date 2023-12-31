namespace LeetCodeChallenge;

// 300. https://leetcode.com/problems/longest-increasing-subsequence/
public class LongestIncreasingSubsequence
{
    public static int LengthOfLIS(int[] nums)
    {
        List<int> piles = new(nums.Length)
        {
            nums[0]
        };

        for (int i = 1; i < nums.Length; i++)
        {
            int num = nums[i];

            if (num > piles[^1])
            {
                piles.Add(num);
                continue;
            }

            // The zero-based index of item in the sorted List, if item is found;
            // Otherwise, a negative number that is the bitwise complement of the index
            // of the next element that is larger than item
            // Or, if there is no larger element, the bitwise complement of List.Count
            int idx = piles.BinarySearch(num);

            if (idx < 0)
            {
                piles[~idx] = num;
            }
        }

        return piles.Count;
    }

    public static int SortedSetLengthOfLIS(int[] nums)
    {
        SortedSet<(int count, int index)> sorted = new()
        {
            (-1, nums.Length - 1)
        };

        for (int i = nums.Length - 2; i >= 0; i--)
        {
            int num = nums[i];
            int curTotal = -1;

            foreach (var (count, index) in sorted)
            {
                if (num < nums[index])  // If the stored value is bigger
                {
                    curTotal += count;
                    break;
                }
            }

            sorted.Add((curTotal, i));
        }

        return -sorted.First().count;
    }
}
