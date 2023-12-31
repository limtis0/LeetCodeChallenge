namespace LeetCodeChallenge;

// 1160. https://leetcode.com/problems/find-words-that-can-be-formed-by-characters/
public class WordsFormedByCharacters
{
    public static int CountCharacters(string[] words, string chars)
    {
        int[] frequency = new int[26];

        for (int i = 0; i < chars.Length; i++)
        {
            frequency[GetCharacterIndex(chars[i])] += 1;
        }

        int sum = 0;
        
        foreach (string word in words)
        {
            sum += word.Length;

            int[] wordFrequency = new int[26];
            foreach (char c in word)
            {
                int index = GetCharacterIndex(c);

                wordFrequency[index] += 1;
                
                if (wordFrequency[index] > frequency[index])
                {
                    sum -= word.Length;
                    break;
                }
            }
        }

        return sum;
    }

    private static int GetCharacterIndex(char c) => c - 'a';
}
