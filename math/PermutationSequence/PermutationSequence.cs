using System.Text;

namespace LeetCodeChallenge;

// 60. https://leetcode.com/problems/permutation-sequence/
public class PermutationSequence
{
    private static readonly int[] factorials = { 1, 1, 2, 6, 24, 120, 720, 5040, 40320 };

    public static string GetPermutation(int n, int k)
    {
        StringBuilder sb = new(n);
        List<int> numbers = new(n);

        for (int i = 1; i <= n; i++)
        {
            numbers.Add(i);
        }

        k--;  // Adjust k to be 0-based

        for (int i = 1; i <= n; i++)
        {
            int factorial = factorials[n - i];

            // Get the index of current digit
            int index = k / factorial;

            // Update k for remaining permutations
            k %= factorial;

            sb.Append(numbers[index]);
            numbers.RemoveAt(index);
        }

        return sb.ToString();
    }
}
