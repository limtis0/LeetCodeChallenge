namespace LeetCodeChallenge;

// 1422. https://leetcode.com/problems/maximum-score-after-splitting-a-string/
public class MaxScoreAfterSplitting
{
    public static int MaxScore(string s)
    {
        (int countOnes, int countZeros, int maxDiff) = (0, 0, int.MinValue);

        for (int i = 0; i < s.Length - 1; i++)
        {
            if (s[i] == '0')
            {
                countZeros++;
            }
            else
            {
                countOnes++;
            }

            maxDiff = Math.Max(maxDiff, countZeros - countOnes); // Store max difference between two counts
        }

        // We don't to store difference for the last number, as strings must be non-empty
        if (s[^1] == '1')
        {
            countOnes++;
        }

        return maxDiff + countOnes;
    }

    public static int MaxScoreTwoPass(string s)
    {
        int countOnes = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '1')
            {
                countOnes++;
            }
        }

        int countZeros = 0;
        int maxScore = s[0] == '0' ? countOnes : countOnes - 1;

        for (int i = 0; i < s.Length - 1; i++)
        {
            if (s[i] == '0')
            {
                countZeros++;
            }
            else
            {
                countOnes--;
            }

            maxScore = Math.Max(maxScore, countZeros + countOnes);
        }

        return maxScore;
    }
}
