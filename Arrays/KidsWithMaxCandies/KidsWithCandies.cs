namespace LeetCodeChallenge;

public class KidsWithCandies {
    // LINQ Solution
    public static IList<bool> Solution(int[] candies, int extraCandies) {
        return candies.Select(c => c + extraCandies >= candies.Max()).ToList();
    }

    // public static IList<bool> Solution(int[] candies, int extraCandies) {
    //     List<bool> res = new();

    //     foreach (int amount in candies)
    //     {
    //         res.Add(amount + extraCandies >= candies.Max());
    //     }

    //     return res;
    // }
}