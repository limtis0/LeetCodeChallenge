namespace LeetCodeChallenge;

// 17. https://leetcode.com/problems/letter-combinations-of-a-phone-number/
public class PhoneNumberCombinations
{
    private static Dictionary<char, string> buttonMap = new()
    {
        {'2', "abc"},
        {'3', "def"},
        {'4', "ghi"},
        {'5', "jkl"},
        {'6', "mno"},
        {'7', "pqrs"},
        {'8', "tuv"},
        {'9', "wxyz"},
    };

    public static IList<string> LetterCombinations(string digits)
    {
        return digits.Length == 0 ? new List<string>() : Recursion(digits).ToList();
    }

    private static IEnumerable<string> Recursion(string digits, string combination = "")
    {
        char button = digits[0];
        string digitsLeft = digits[1..];
        
        if (digitsLeft.Length == 0)
        {
            foreach (char letter in buttonMap[button])
            {
                yield return combination + letter;
            }
        }
        else
        {
            foreach (char letter in buttonMap[button])
            {
                foreach (string c in Recursion(digitsLeft, combination + letter))
                {
                    yield return c;
                };
            }
        }

        yield break;
    }
}
