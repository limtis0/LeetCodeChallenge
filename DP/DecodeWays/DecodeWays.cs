namespace LeetCodeChallenge;

// 91. https://leetcode.com/problems/decode-ways/
public class DecodeWays
{
    public static int NumDecodings(string s)
    {
        if (s[0] == '0')
        {
            return 0;
        }

        int[] result = new int[s.Length + 1];
        result[0] = 1;
        result[1] = 1;

        for (int i = 2; i <= s.Length; i++)
        {
            int current = s[i - 1] - '0';
            int prev = s[i - 2] - '0';

            if (current > 0)
            {
                result[i] = result[i - 1];
            }

            int sumWithPrev = prev * 10 + current;
            if (sumWithPrev >= 10 && sumWithPrev <= 26)
            {
                result[i] += result[i - 2];
            }
        }

        return result[^1];
    }
}
