namespace LeetCodeChallenge;

// 1207. https://leetcode.com/problems/unique-number-of-occurrences/
public class UniqueOccurrences
{
    public static bool IsUnique(int[] arr)
    {
        Dictionary<int, int> keyCount = new();

        foreach (int key in arr)
        {
            keyCount.TryGetValue(key, out int value);
            keyCount[key] = value + 1;
        }

        HashSet<int> values = new();

        foreach (int value in keyCount.Values)
        {
            if (values.Contains(value))
            {
                return false;
            }
            values.Add(value);
        }

        return true;
    }
}
