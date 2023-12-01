namespace LeetCodeChallenge;

// 238. https://leetcode.com/problems/product-of-array-except-self/
public class ArrayStringsAreEqual
{
    public static bool Solution(string[] word1, string[] word2)
    {
        return EnumStrings(word1).SequenceEqual(EnumStrings(word2));
    }

    private static IEnumerable<char> EnumStrings(string[] words) 
    {
        foreach (string word in words)
        {
            foreach (char c in word)
            {
                yield return c;
            }
        }
    }
}