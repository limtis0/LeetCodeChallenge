namespace LeetCodeChallenge;

// 151. https://leetcode.com/problems/reverse-words-in-a-string/
public class ReverseWordsInString
{
    public static string Reverse(string s)
    {
        return string.Join(' ', s.Split(' ').Where(x => !string.IsNullOrWhiteSpace(x)).Reverse());
    }
}
