namespace LeetCodeChallenge;

// 1657. https://leetcode.com/problems/determine-if-two-strings-are-close/
public class CloseStrings
{
    public static bool AreClose(string word1, string word2)
    {
        if (word1.Length != word2.Length)
        {
            return false;
        }

        Dictionary<char, int> frequencies1 = new();
        Dictionary<char, int> frequencies2 = new();

        Dictionary<int, int> multiset = new(); // Contains frequency-values for frequencies1

        // Count letter occurencies
        foreach (var (First, Second) in word1.Zip(word2))
        {
            int newFrequency = IncrementDictionary(frequencies1, First);
            IncrementDictionary(frequencies2, Second);

            // Adjust a multiset
            IncrementDictionary(multiset, newFrequency);

            if (newFrequency > 1)
            {
                multiset[newFrequency - 1] -= 1;
            }
        }

        // Check whether word2 has the same amount of unique values
        foreach (var (Key, Value) in frequencies2)
        {
            if (!frequencies1.ContainsKey(Key))
            {
                return false;
            }

            multiset.TryGetValue(Value, out int count);

            // If nothing left or non-existent
            if (count == 0)
            {
                return false;
            }

            multiset[Value] -= 1;
        }

        return true;
    }

    private static int IncrementDictionary<T>(IDictionary<T, int> dict, T key)
    {
        dict.TryGetValue(key, out int value);
        dict[key] = value + 1;

        return dict[key];
    }
}
