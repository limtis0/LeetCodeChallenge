using System.Text;

namespace LeetCodeChallenge;

// 12. https://leetcode.com/problems/integer-to-roman/
public class IntegerToRoman
{
    private static readonly List<(string symbol, int value)> symbols = new()
    {
        ("M", 1000),
        ("CM", 900),
        ("D", 500),
        ("CD", 400),
        ("C", 100),
        ("XC", 90),
        ("L", 50),
        ("XL", 40),
        ("X", 10),
        ("IX", 9),
        ("V", 5),
        ("IV", 4),
        ("I", 1)
    };

    public static string IntToRoman(int num)
    {
        StringBuilder sb = new();

        foreach (var (symbol, value) in symbols)
        {
            while (value <= num)
            {
                num -= value;
                sb.Append(symbol);
            }
        }

        return sb.ToString();
    }
}
