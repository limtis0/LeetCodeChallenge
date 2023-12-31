namespace LeetCodeChallenge;

// 1287. https://leetcode.com/problems/element-appearing-more-than-25-in-sorted-array/
public class ElementAppearingMoreThan25
{
    public static int FindSpecialInteger(int[] arr)
    {
        int quarter = arr.Length >> 2;  // Divide by 4 and floor

        // For first two candidates
        for (int i = 1; i <= 2; i++)
        {
            int index = arr.Length * i / 4;
            int cand = arr[index];
            
            // Find leftmost using binary-search
            int leftmost = FindLeftmostIndex(arr, cand, index);

            // If persists after 25% of array
            if (arr[leftmost + quarter] == cand)
            {
                return cand;
            }
        }

        // If 2 of 3 candidates are out, return the third
        return arr[arr.Length * 3 / 4];
    }

    private static int FindLeftmostIndex(int[] array, int target, int high)
    {
        int low = 0;
        int leftmostIndex = -1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (array[mid] == target)
            {
                leftmostIndex = mid;
                // Continue searching to the left
                high = mid - 1;
            }
            else if (array[mid] < target)
            {
                // Search the right half
                low = mid + 1;
            }
            else
            {
                // Search the left half
                high = mid - 1;
            }
        }

        return leftmostIndex;
    }

    // It is O(1), but wrong ;)
    public static int FindSpecialIntegerWrongButPassing(int[] arr)
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
