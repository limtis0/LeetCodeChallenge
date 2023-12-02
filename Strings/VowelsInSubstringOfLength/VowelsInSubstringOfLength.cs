using System.Collections;

namespace LeetCodeChallenge;

// 1456. https://leetcode.com/problems/maximum-number-of-vowels-in-a-substring-of-given-length/
public class VowelsInSubstringOfLength
{
    public static int MaxVowels(string s, int k) 
    {
        int count = 0;
        byte[] vowels = new byte[s.Length];

        // Check first k elements
        for (int i = 0; i < k; i++)
        {
            if (IsVowel(s[i]))
            {
                vowels[i] = 1;
                count++;
            }
        }

        int maxCount = count;

        // Sliding window
        for (int i = k; i < s.Length; i++)
        {  
            // Remove the leftmost character
            count -= vowels[i - k];

            if (IsVowel(s[i]))
            {
                count++;
                vowels[i] = 1;
            }

            maxCount = Math.Max(maxCount, count);
        }

        return maxCount;
    }

    // Instead of Set, more memory-efficient
    private static bool IsVowel(char c)
    {
        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
    }
}
