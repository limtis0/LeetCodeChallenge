namespace LeetCodeChallenge;

// 443. https://leetcode.com/problems/string-compression/
public class StringCompression
{
    public static int Compress(char[] chars)
    {
        char currentChar = chars[0];
        int sequenceSize = 1;
        int writeIndex = 0;

        for (int i = 1; i < chars.Length; i++)
        {
            // If same character
            if (chars[i] == currentChar)
            {
                sequenceSize++;
                continue;
            }

            // If not, write the character to array
            WriteSequence(currentChar, sequenceSize, ref writeIndex, chars);
            
            currentChar = chars[i];
            sequenceSize = 1;
        }

        // Write the last sequence, as it is skipped by for-loop
        WriteSequence(currentChar, sequenceSize, ref writeIndex, chars);

        return writeIndex;
    }

    private static void WriteSequence(char writeCharacter, int sequenceSize, ref int writeIndex, char[] chars)
    {
        chars[writeIndex] = writeCharacter;
        writeIndex++;

        if (sequenceSize > 1)
        {
            foreach (char c in sequenceSize.ToString())
            {
                chars[writeIndex] = c;
                writeIndex++;
            }
        }
    }
}
