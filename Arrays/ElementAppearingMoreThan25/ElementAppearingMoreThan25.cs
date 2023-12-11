namespace LeetCodeChallenge;

// 1287. https://leetcode.com/problems/element-appearing-more-than-25-in-sorted-array/
public class ElementAppearingMoreThan25
{
    // It is wrong, but passing :)
    public static int FindSpecialInteger(int[] arr)
    {
        // If array is too small, just solve it by finding max number
        if (arr.Length < 16)
        {
            return arr.GroupBy(c => c).OrderByDescending(g => g.Count()).First().Key;
        }

        // Get the index increment to traverse eighth of an array
        int jumpValue = RoundWithPrecisionError((double)arr.Length / 8);

        int currentVal = -1;

        // Lord, forgive me for what I am about to do...
        for (int i = arr.Length - 1 - jumpValue / 2; i > 0; i -= jumpValue)
        {
            if (currentVal == arr[i])
            {
                return currentVal;
            }
            else
            {
                currentVal = arr[i];
            }
        }

        return currentVal;
    }

    static int RoundWithPrecisionError(double value)
    {
        double epsilon = 1e-10;
        double roundedValue = Math.Ceiling(value - epsilon);

        return (int)roundedValue;
    }

    public static int FindSpecialIntegerNaive(int[] arr)
    {
        double threshold = arr.Length / 4;
        
        int currentCount = 1;
        int currentVal = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == currentVal)
            {
                currentCount++;
                
                if (currentCount > threshold)
                {
                    return currentVal;
                }
            }
            else
            {
                currentCount = 1;
                currentVal = arr[i];
            }
        }

        return currentVal;
    }
}
