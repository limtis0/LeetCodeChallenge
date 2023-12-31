namespace LeetCodeChallenge;

// 2610. https://leetcode.com/problems/convert-an-array-into-a-2d-array-with-conditions/
public class ConvertInto2DArray
{
    public static IList<IList<int>> FindMatrix(int[] nums)
    {
        List<IList<int>> result = new()
        {
            new List<int>()
        };

        int[] frequency = new int[nums.Length];
        int maxFrequency = 0;

        foreach (int num in nums)
        {
            int currentFrequency = frequency[num - 1]++;

            if (currentFrequency > maxFrequency)
            {
                maxFrequency = currentFrequency;
                result.Add(new List<int> { num });
            }
            else
            {
                result[currentFrequency].Add(num);
            }
        }

        return result;
    }

    public static IList<IList<int>> FindMatrixHashmap(int[] nums)
    {
        List<IList<int>> result = new()
        {
            new List<int>()
        };

        Dictionary<int, int> numToCount = new();
        int currentCount;

        foreach (int num in nums)
        {
            currentCount = numToCount.GetValueOrDefault(num);

            if (currentCount >= result.Count)
            {
                result.Add(new List<int>() { num });
            }
            else
            {
                result[currentCount].Add(num);
            }

            numToCount[num] = currentCount + 1;
        }

        return result;
    }
}
