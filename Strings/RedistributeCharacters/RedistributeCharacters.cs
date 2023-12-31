namespace LeetCodeChallenge;

// 1897. https://leetcode.com/problems/redistribute-characters-to-make-all-strings-equal/
public class RedistributeCharacters
{
    public static bool MakeEqual(string[] words)
    {
        int[] frequency = new int[26];

        foreach (string word in words)
        {
            foreach (char c in word)
            {
                frequency[c - 'a']++;
            }
        }

        return frequency.All(f => f % words.Length == 0);
    }
}
