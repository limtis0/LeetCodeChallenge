namespace LeetCodeChallenge;

// 1436. https://leetcode.com/problems/destination-city/
public class DestinationCity
{
    public static string DestCity(IList<IList<string>> paths)
    {
        HashSet<string> fromCities = new();

        foreach (var path in paths)
        {
            fromCities.Add(path[0]);
        }

        foreach (var path in paths)
        {
            if (!fromCities.Contains(path[1]))
            {
                return path[1];
            }
        }

        return string.Empty;
    }
}
