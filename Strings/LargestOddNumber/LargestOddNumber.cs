namespace LeetCodeChallenge;

// #. URL
public class LargestOddNumber
{
    public static string Solution(string num)
    {
        for (int i = num.Length - 1; i >= 0; i--)
        {
            if ((num[i] - '0') % 2 == 1)
            {
                return num[..(i + 1)];
            }
        }

        return string.Empty;
    }
}
