namespace LeetCodeChallenge;

// 1624. https://leetcode.com/problems/largest-substring-between-two-equal-characters/
public class LargestSubstringBetweenTwoChars
{
    private class Letter
    {
        int First { get; set; } = -1;
        int Second { get; set; } = -1;

        public Letter() { }

        public int UpdateAndGetDifference(int num)
        {
            if (First == -1)
            {
                First = num;

                return -1;
            }

            Second = num;

            return Second - First - 1;
        }
    }

    public static int MaxLengthBetweenEqualCharacters(string s)
    {
        if (s.Length <= 1)
        {
            return -1;
        }

        Letter[] letters = new Letter[26];

        for (int i = 0; i < 26; i++)
        {
            letters[i] = new();
        }

        int maxDifference = -1;

        for (int i = 0; i < s.Length; i++)
        {
            Letter letter = letters[s[i] - 'a'];

            maxDifference = Math.Max(maxDifference, letter.UpdateAndGetDifference(i));
        }

        return maxDifference;
    }
}
