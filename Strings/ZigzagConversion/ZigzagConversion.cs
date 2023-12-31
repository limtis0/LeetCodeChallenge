using System.Text;

namespace LeetCodeChallenge;

// 6. https://leetcode.com/problems/zigzag-conversion/
public class ZigzagConversion
{
    public static string Convert(string s, int numRows)
    {
        List<char>[] lines = new List<char>[numRows];

        // Initialize each list for line
        for (int i = 0; i < numRows; i++)
        {
            lines[i] = new();
        }

        int charInd = 0;

        // Fill
        while (charInd < s.Length)
        {
            for (int lineInd = 0; lineInd < numRows && charInd < s.Length; lineInd++)
            {
                lines[lineInd].Add(s[charInd++]);
            }

            for (int lineInd = numRows - 2; lineInd > 0 && charInd < s.Length; lineInd--)
            {
                lines[lineInd].Add(s[charInd++]);
            }
        }

        StringBuilder sb = new();

        foreach (var line in lines)
        {
            foreach (char c in line)
            {
                sb.Append(c);
            }
        }

        return sb.ToString();
    }
}
