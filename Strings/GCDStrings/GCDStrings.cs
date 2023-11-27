namespace LeetCodeChallenge;

public class GCDStrings {
    public static string FindGDCString(string x, string y) {
        if (x.Length == y.Length && x != y) {
            return string.Empty;
        }

        // Make X a smaller string
        if (x.Length < y.Length) {
            (x, y) = (y, x);
        }

        // Start from the biggest
        for (int i = x.Length; i > 0; i--) {
            // Ignore non-common divisors
            if (x.Length % i != 0 || y.Length % i != 0) {
                continue;
            }

            // Get substring of X
            string sub = x[..i];

            // Check whether it is repeating in X and Y
            if (IsRepeatedSubstring(sub, x) && IsRepeatedSubstring(sub, y)) {
                return sub;
            }
        }

        return string.Empty;
    }

    private static bool IsRepeatedSubstring(string sub, string original) {
        for (int i = 0; i < original.Length; i += sub.Length) {
            string cmpSub = original.Substring(i, sub.Length);    
            
            if (sub != cmpSub) {
                return false;
            }
        }

        return true;
    }
}