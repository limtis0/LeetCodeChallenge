namespace LeetCodeChallenge;

// 2125. https://leetcode.com/problems/number-of-laser-beams-in-a-bank/
public class NumberOfLaserBeams
{
    public static int NumberOfBeams(string[] bank)
    {
        if (bank.Length == 1)
        {
            return 0;
        }

        // Calculate the first row
        int prevCount = bank[0].Count(c => c == '1');

        int totalSum = 0;

        // Calculate next rows
        for (int i = 1; i < bank.Length; i++)
        {
            int currentCount = bank[i].Count(c => c == '1');

            if (currentCount != 0)
            {
                totalSum += prevCount * currentCount;
                prevCount = currentCount;
            }
        }

        return totalSum;
    }
}
