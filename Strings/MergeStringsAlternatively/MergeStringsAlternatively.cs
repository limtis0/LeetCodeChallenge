using System.Text;

namespace LeetCodeChallenge;

public class MergeStringsAlternatively {
    public static string MergeAlternatively(string x, string y) {
        StringBuilder sb = new();

        // Same-length part
        foreach (var (First, Second) in x.Zip(y)) {
            sb.Append(First);
            sb.Append(Second);
        }
        
        var leftover = (x.Length > y.Length) ? x[y.Length..] : y[x.Length..];
        sb.Append(leftover);

        return sb.ToString();
    }

    // // KISS APROACH
    // public static string MergeAlternatively(string x, string y) {
    //     StringBuilder sb = new();

    //     int i = 0;

    //     while (i < x.Length && i < y.Length) {
    //         sb.Append(x[i]);
    //         sb.Append(y[i]);
    //         i++;
    //     }

    //     while (i < x.Length) {
    //         sb.Append(x[i]);
    //         i++;
    //     }

    //     while (i < y.Length) {
    //         sb.Append(y[i]);
    //         i++;
    //     }

    //     return sb.ToString();
    // }
}