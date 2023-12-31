namespace LeetCodeChallenge;

// 14. https://leetcode.com/problems/longest-common-prefix/
public class LongestCommonPrefix
{
    public static string SolutionVertical(string[] strs)
    {
        string prefix = strs[0];
        int maxLength = 0;

        while (true)
        {
            try
            {
                char current = prefix[maxLength];

                if (strs.All(s => s[maxLength] == current))
                {
                    maxLength++;
                }
                else
                {
                    break;
                }
            }
            catch (IndexOutOfRangeException)
            {
                break;
            }
        }

        return maxLength == 0 ? string.Empty : prefix[..maxLength];
    }

    public static string Solution(string[] strs)
    {
        string prefix = strs[0];
        int maxLength = prefix.Length;

        for (int stringInd = 1; stringInd < strs.Length; stringInd++)
        {
            string currentStr = strs[stringInd];

            for (int charInd = 0; charInd < maxLength; charInd++)
            {
                if (charInd == currentStr.Length)
                {
                    maxLength = charInd;
                    break;
                }

                if (prefix[charInd] != currentStr[charInd])
                {
                    maxLength = charInd;
                    break;
                }
            }
        }

        return maxLength == 0 ? string.Empty : prefix[..maxLength];
    }
}
