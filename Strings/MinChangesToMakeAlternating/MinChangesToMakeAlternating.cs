namespace LeetCodeChallenge;

// 1758. https://leetcode.com/problems/minimum-changes-to-make-alternating-binary-string/
public class MinChangesToMakeAlternating
{
    public static int MinOperations(string s)
    {
        int countFromOne = 0;
        int countFromZero = 0;

        char currentChar = '0';

        foreach (char c in s)
        {
            if (c == currentChar)
            {
                countFromOne++;
            }
            else
            {
                countFromZero++;
            }

            currentChar = (char)(currentChar ^ 1);
        }

        return Math.Min(countFromZero, countFromOne);
    }
}
