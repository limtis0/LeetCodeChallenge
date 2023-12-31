namespace LeetCodeChallenge;

// 1716. https://leetcode.com/problems/calculate-money-in-leetcode-bank/
public class MoneyInBank
{
    public static int TotalMoney(int n)
    {
        var (totalWeeks, extraDays) = Math.DivRem(n, 7);

        int total = 28 * totalWeeks; // Basic 28 for each week (without bonuses)

        total += (totalWeeks - 1) * (7 + 7 * (totalWeeks - 1)) / 2; // Calculate sum of bonuses as arithmetic progression

        total += extraDays * (totalWeeks + totalWeeks + extraDays + 1) / 2; // Add extra bonuses for unfinished week

        return total;
    }

    public static int TotalMoneySemiNaive(int n)
    {
        int total = 0;
        int currentStart = 1;

        while (n > 7)
        {
            total += SumOfProgression(7, currentStart, currentStart + 6);

            n -= 7;
            currentStart++;
        }

        total += SumOfProgression(n, currentStart, currentStart + n - 1);

        return total;
    }

    private static int SumOfProgression(int n, int start, int end) => n * (start + end) / 2;
}
