namespace LeetCodeChallenge;

// 242. https://leetcode.com/problems/valid-anagram/
public class ValidAnagram
{
    public static bool IsAnagram(string s, string t)
    {
        int[] letterCount = new int[26];  // Given s and t consisting only of lowercase english letters

        if (s.Length != t.Length)
        {
            return false;
        }

        for (int i = 0; i < s.Length; i++)
        {
            letterCount[s[i] - 'a']++;
            letterCount[t[i] - 'a']--;
        }

        return letterCount.All(c => c == 0);
    }
}
