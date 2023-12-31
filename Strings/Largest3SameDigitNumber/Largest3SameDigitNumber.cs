namespace LeetCodeChallenge;

// #. URL
public class Largest3SameDigitNumber
{
    public static string Solution(string num)
    {
        char currentChar = num[0];
        int currentCount = 1;
        int biggestNum = -1;

        for (int i = 1; i < num.Length; i++)
        {
            char nextChar = num[i];

            if (currentChar == nextChar)
            {
                currentCount++;

                if (currentCount == 3)
                {
                    biggestNum = Math.Max(biggestNum, currentChar - '0');
                }
            }
            else
            {
                currentChar = nextChar;
                currentCount = 1;
            }
        }

        if (biggestNum == -1)
        {
            return string.Empty;
        }

        return string.Concat(Enumerable.Repeat(biggestNum, 3));
    }
}
