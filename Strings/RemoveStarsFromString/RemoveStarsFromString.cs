using System.Text;

namespace LeetCodeChallenge;

// 2390. https://leetcode.com/problems/removing-stars-from-a-string/
public class RemoveStarsFromString
{
    public static string RemoveStars(string s)
    {
        StringBuilder result = new();

        foreach (char c in s)
        {
            if (c == '*')
            {
                result.Length--;
            }
            else
            {
                result.Append(c);
            }
        }

        return result.ToString();
    }
}
