namespace LeetCodeChallenge;

// 1531. https://leetcode.com/problems/string-compression-ii/
public class StringCompressionII
{
    public static int GetLengthOfOptimalCompression(string s, int k)
    {
        Dictionary<(int, int, char, int), int> memo = new();

        int DP(int index, int deletesLeft, char prevChar, int prevCharCount)
        {
            // Can't continue further, as all the deletes are used
            if (deletesLeft < 0)
            {
                return int.MaxValue;
            }

            // No characters left, can't be less than that
            if (index == s.Length)
            {
                return 0;
            }

            // Memoization
            var memoKey = (index, deletesLeft, prevChar, prevCharCount);
            
            if (memo.ContainsKey(memoKey))
            {
                return memo[memoKey];
            }

            // Delete just leaves the previous character the same
            int choiceDelete = DP(index + 1, deletesLeft - 1, prevChar, prevCharCount);
            int choiceKeep;

            if (s[index] == prevChar)
            {
                choiceKeep = DP(index + 1, deletesLeft, prevChar, prevCharCount + 1);

                // Increment when surpassing values, requiring an additional symbol
                if (prevCharCount == 1 || prevCharCount == 9 || prevCharCount == 99)
                {
                    choiceKeep++;
                }
            }
            else  // On new character - increment
            {
                choiceKeep = DP(index + 1, deletesLeft, s[index], 1) + 1;
            }

            int result = Math.Min(choiceDelete, choiceKeep);

            memo[memoKey] = result;

            return result;
        }

        return DP(0, k, '\0', 0);
    }
}
