namespace LeetCodeChallenge;

// 13. https://leetcode.com/problems/roman-to-integer/
public class RomanToInteger
{
    public static int RomanToInt(string s)
    {
        int sum = 0;

        for (int i = 0; i < s.Length - 1; i++)
        {
            int current = RomanNumerals(s[i]);
            int sign = RomanNumerals(s[i + 1]) > current ? -1 : 1;

            sum += sign * current;
        }

        sum += RomanNumerals(s[^1]);

        return sum;
    }

    private static int RomanNumerals(char c)
    {
        switch (c)
        {
            case 'M':
                return 1000;
            case 'D':
                return 500;
            case 'C':
                return 100;
            case 'L':
                return 50;
            case 'X':
                return 10;
            case 'V':
                return 5;
            case 'I':
                return 1;
        }
        ;

        return 0;
    }
}
