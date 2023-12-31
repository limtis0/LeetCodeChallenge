namespace LeetCodeChallenge;

// 26. https://leetcode.com/problems/remove-duplicates-from-sorted-array/
public class RemoveDuplicatesFromSorted
{
    public static int RemoveDuplicates(int[] nums)
    {
        int p = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i-1])
            {
                nums[p] = nums[i];
                p++;
            }
        }

        return p;
    }
}
