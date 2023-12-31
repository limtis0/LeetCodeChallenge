using System.Text;

namespace LeetCodeChallenge;

// 68. https://leetcode.com/problems/text-justification/
public class TextJustification
{
    // Separates the words into lines fitting maxWidth
    private static List<List<string>> SeparateLines(string[] words, int maxWidth)
    {
        List<List<string>> lines = new();

        for (int indWord = 0; indWord < words.Length; )
        {
            // First word is guaranteed to fit
            List<string> line = new() { words[indWord] };
            int lineLength = line[0].Length;

            while (++indWord < words.Length)
            {
                string word = words[indWord];

                // If next word doesn't fit
                if (lineLength + word.Length + 1 > maxWidth)
                {
                    break;
                }

                line.Add(word);
                lineLength += word.Length + 1;
            }

            lines.Add(line);
        }

        return lines;
    }

    // Justifies the line and appends it to StringBuilder
    private static void JustifyCenter(
        IList<string> line,
        int totalSpaces,
        int gaps,
        StringBuilder sb
    )
    {
        (int spacePerGap, int extraSpace) = Math.DivRem(totalSpaces, gaps);

        string spaces = new(' ', spacePerGap);

        sb.Append(line[0]);

        for (int wordInd = 1; wordInd < line.Count; wordInd++)
        {
            sb.Append(spaces);

            if (wordInd <= extraSpace)
            {
                sb.Append(' ');
            }

            sb.Append(line[wordInd]);
        }
    }

    public static IList<string> FullJustify(string[] words, int maxWidth)
    {
        List<List<string>> lines = SeparateLines(words, maxWidth);

        List<string> justified = new();
        StringBuilder sb = new(maxWidth);

        for (int i = 0; i < lines.Count - 1; i++)
        {
            List<string> currentLine = lines[i];

            // If only one word
            if (currentLine.Count == 1)
            {
                justified.Add(currentLine[0].PadRight(maxWidth));
            }
            else
            {
                int totalSpaces = maxWidth - currentLine.Sum(w => w.Length);
                int gaps = currentLine.Count - 1;

                // If only one space
                if (gaps == 1)
                {
                    string spaces = new(' ', totalSpaces);

                    justified.Add($"{currentLine[0]}{spaces}{currentLine[1]}");
                }
                else
                {
                    JustifyCenter(currentLine, totalSpaces, gaps, sb);

                    justified.Add(sb.ToString());
                    sb.Clear();
                }
            }
        }

        // For the last line
        justified.Add(string.Join(' ', lines[^1]).PadRight(maxWidth));

        return justified;
    }
}
