namespace LeetCodeChallenge;

// 345. https://leetcode.com/problems/reverse-vowels-of-a-string/
public class ReverseVowels
{
    private static readonly HashSet<char> vowels =
        new() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

    public static string Reverse(string s)
    {
        char[] chars = new char[s.Length];

        int p1 = 0;
        int p2 = s.Length - 1;

        while (p1 < p2)
        {
            // If not a vowel
            if (!vowels.Contains(s[p1]))
            {
                chars[p1] = s[p1];
                p1++;
                continue;
            }

            // Find the closest vowel for p2
            while (p2 > p1 && !vowels.Contains(s[p2]))
            {
                chars[p2] = s[p2];
                p2--;
            }

            // Swap vowels and move pointers
            (chars[p1], chars[p2]) = (s[p2], s[p1]);
            p2--;
            p1++;
        }

        // Cover the edge-case of missing the last char
        if (chars[p1] == '\0')
        {
            chars[p1] = s[p1];
        }

        return new string(chars);
    }
}
