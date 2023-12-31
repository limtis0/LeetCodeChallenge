namespace LeetCodeChallenge;

// 22. https://leetcode.com/problems/generate-parentheses/
public class GenerateParentheses
{
    public static IList<string> GenerateParenthesis(int n)
    {
        List<string> result = new();

        void Generate(string current, int toOpen, int toClose)
        {
            if (toOpen == 0)
            {
                result.Add(current + new string(')', toClose));

                return;
            }

            if (toOpen > 0)
            {
                Generate(current + '(', toOpen - 1, toClose + 1);
            }

            if (toClose > 0)
            {
                Generate(current + ')', toOpen, toClose - 1);
            }
        }
        
        Generate("(", n - 1, 1);

        return result;
    }
}
