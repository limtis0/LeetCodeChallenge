namespace LeetCodeChallenge;

// 2260. https://leetcode.com/problems/minimum-consecutive-cards-to-pick-up/
public class MinimumConsecutiveCards
{
    public static int MinimumCardPickup(int[] cards)
    {
        int minValue = cards.Length + 1;

        Dictionary<int, int> cardToInd = new();

        for (int ind = 0; ind < cards.Length; ind++)
        {
            int card = cards[ind];

            if (cardToInd.ContainsKey(card))
            {
                minValue = Math.Min(minValue, ind - cardToInd[card] + 1);
            }

            cardToInd[card] = ind;
        }

        return minValue > cards.Length ? -1 : minValue;
    }
}
