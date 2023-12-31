namespace LeetCodeChallenge;

// 75. https://leetcode.com/problems/sort-colors/
public class SortColors
{
    public static void Solution(int[] nums)
    {
        int zero, one, two;
        zero = one = 0;
        two = nums.Length - 1;

        while (one < two)
        {
            switch (nums[one])
            {
                case 0:
                    (nums[zero], nums[one]) = (nums[one], nums[zero]);
                    zero++;
                    one++;
                    break;
                
                case 1:
                    one++;
                    break;

                case 2:
                    (nums[one], nums[two]) = (nums[two], nums[one]);
                    two--;
                    break;
            }
        }
    }

    public static void SolutionSlowAndFast(int[] nums)
    {
        int zero, one;

        zero = one = -1;

        for (int i = 0; i < nums.Length; i++)
        {
            switch (nums[i])
            {
                case 1:
                    nums[i] = 2;
                    nums[++one] = 1;
                    break;

                case 0:
                    nums[i] = 2;
                    nums[++one] = 1;
                    nums[++zero] = 0;
                    break;
            }
        }
    }

    public static void SolutionRewrite(int[] nums)
    {
        int[] count = new int[3];

        // Count each color
        foreach (int num in nums)
        {
            count[num]++;
        }

        int writeInd = 0;

        // Fill in the values
        for (int i = 0; i < 3; i++)
        {
            while (count[i] > 0)
            {
                nums[writeInd] = i;
                count[i]--;
                writeInd++;
            }
        }
    }
}
