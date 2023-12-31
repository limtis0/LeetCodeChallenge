namespace LeetCodeChallenge;

// 1137. https://leetcode.com/problems/n-th-tribonacci-number/
public class NthTribonacciNumber
{
    public static int Tribonacci(int n)
    {
        // Edge-cases
        if (n < 3)
        {
            switch (n)
            {
                case 0:
                    return 0;
                case 1:
                    return 1;
                case 2:
                    return 1;
            }
        }

        (int n1, int n2, int n3) = (0, 1, 1);

        for (int i = 0; i < n - 2; i++)
        {
            (n1, n2, n3) = (n2, n3, n1 + n2 + n3);
        }

        return n3;
    }

    // Made as a joke xD
    private static readonly int[] precomputed = new int[]
    {
        0,
        1,
        1,
        2,
        4,
        7,
        13,
        24,
        44,
        81,
        149,
        274,
        504,
        927,
        1705,
        3136,
        5768,
        10609,
        19513,
        35890,
        66012,
        121415,
        223317,
        410744,
        755476,
        1389537,
        2555757,
        4700770,
        8646064,
        15902591,
        29249425,
        53798080,
        98950096,
        181997601,
        334745777,
        615693474,
        1132436852,
        2082876103
    };

    public static int PreCompute(int n) => precomputed[n];
}
