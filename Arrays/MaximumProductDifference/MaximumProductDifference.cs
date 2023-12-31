namespace LeetCodeChallenge;

// 1913. https://leetcode.com/problems/maximum-product-difference-between-two-pairs/
public class MaximumProductDifference
{
    public static int MaxProductDifference(int[] nums)
    {
        var (firstMax, secondMax, firstMin, secondMin) = (0, 0, int.MaxValue, int.MaxValue);

        foreach (int num in nums) 
        {
            // Fill in the max
            if (num > firstMax)
            {
                secondMax = firstMax;
                firstMax = num;
            }
            else if (num > secondMax)
            {
                secondMax = num;
            }
            
            // Fill in the min
            if (num < firstMin)
            {
                secondMin = firstMin;
                firstMin = num;
            }
            else if (num < secondMin)
            {
                secondMin = num;
            }
        }

        return firstMax * secondMax - firstMin * secondMin;
    }
}
