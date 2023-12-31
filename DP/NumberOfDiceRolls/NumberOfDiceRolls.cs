namespace LeetCodeChallenge;

// 1155. https://leetcode.com/problems/number-of-dice-rolls-with-target-sum/
public class NumberOfDiceRolls
{
    private const int Cap = (int)(1e9 + 7);
    
    public static int NumRollsToTarget(int n, int k, int target)
    {
        Dictionary<(int nDice, int target), long> memo = new();

        long DP(int numDice, int targetValue)
        {
            if (numDice == 0)
            {
                return targetValue > 0 ? 0 : 1;
            }

            if (memo.ContainsKey((numDice, targetValue)))
            {
                return memo[(numDice, targetValue)];
            }

            long sum = 0;

            for (int i = Math.Max(0, targetValue - k); i < targetValue; i++)
            {
                sum = (sum + DP(numDice - 1, i)) % Cap;
            }

            memo[(numDice, targetValue)] = sum;
            
            return sum;
        }

        return (int)(DP(n, target) % Cap);
    }
}
