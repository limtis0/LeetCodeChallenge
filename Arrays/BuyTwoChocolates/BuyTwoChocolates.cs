namespace LeetCodeChallenge;

// 2706. https://leetcode.com/problems/buy-two-chocolates/
public class BuyTwoChocolates
{
    public static int BuyChoco(int[] prices, int money)
    {
        int firstLowest = int.MaxValue;
        int secondLowest = int.MaxValue;

        for (int i = 0; i < prices.Length; i++)
        {
            int price = prices[i];
            
            if (price < firstLowest)
            {
                secondLowest = firstLowest;
                firstLowest = price;
            }
            else if (price < secondLowest)
            {
                secondLowest = price;
            }
        }

        int leftover = money - firstLowest - secondLowest;

        return leftover >= 0 ? leftover : money;
    }
}
