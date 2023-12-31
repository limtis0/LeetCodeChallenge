namespace LeetCodeChallenge;

// 2348. https://leetcode.com/problems/number-of-zero-filled-subarrays/
public class NumberOfZeroFilledSubarrays
{
    public static long ZeroFilledSubarray(int[] nums)
    {
        long sum = 0;
        long zeroCounter = 0;

        foreach (int n in nums)
        {
            if (n == 0)
            {
                zeroCounter++;
                sum += zeroCounter;
            }
            else
            {
                zeroCounter = 0;
            }
        }

        return sum;
    }

    public static long ZeroFilledSubarrayProgression(int[] nums)
    {
        long sum = 0;
        long zeroCounter = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                zeroCounter++;
            }
            else
            {
                if (zeroCounter > 0)
                {
                    sum += GetAmountOfSubbarays(zeroCounter);
                    zeroCounter = 0;
                }
            }
        }

        if (zeroCounter > 0)
        {
            sum += GetAmountOfSubbarays(zeroCounter);
        }

        return sum;
    }

    private static long GetAmountOfSubbarays(long zeroCounter)
    {
        return (1 + zeroCounter) * zeroCounter / 2;
    }
}
