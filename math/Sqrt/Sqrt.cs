namespace LeetCodeChallenge;

// 69 (nice). https://leetcode.com/problems/sqrtx/
public class Sqrt
{
    public static int MySqrt(int x)
    {
        if (x == 0)
        {
            return 0;
        }

        long low = 1;
        long high = x / 2;

        while (low < high)
        {
            long middle = (low + high) / 2;
            long squared = middle * middle;

            if (squared == x)
            {
                return (int)middle;
            }
            else if (squared > x)
            {
                high = middle;
            }
            else
            {
                if ((middle + 1) * (middle + 1) > x)
                {
                    return (int)middle;
                }

                low = middle + 1;
            }
        }

        return (int)low;
    }
}
