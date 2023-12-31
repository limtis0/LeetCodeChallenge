namespace LeetCodeChallenge;

// 1464. https://leetcode.com/problems/maximum-product-of-two-elements-in-an-array/
public class MaximumProductOfTwoElements
{
    public static int MaxProduct(int[] nums)
    {
        int maxFirst = 0;
        int maxSecond = 0;

        foreach (int num in nums)
        {
            if (num > maxFirst)
            {
                maxSecond = maxFirst;
                maxFirst = num;
            }
            else if (num > maxSecond)
            {
                maxSecond = num;
            }
        }

        return (maxFirst - 1) * (maxSecond - 1);
    }
}
