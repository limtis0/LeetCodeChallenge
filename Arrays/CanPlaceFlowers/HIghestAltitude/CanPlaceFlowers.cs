namespace LeetCodeChallenge;

// 605. https://leetcode.com/problems/can-place-flowers/
public class CanPlaceFlowers
{
    public static bool Solution(int[] flowerbed, int n)
    {
        int places = 0;

        // {1}
        if (flowerbed.Length == 1)
        {
            return n == 0 || flowerbed[0] == 0;
        }

        // First index
        if (flowerbed[0] == 0 && flowerbed[1] == 0)
        {
            flowerbed[0] = 1;
            places += 1;
        }

        // [2, n-1]
        for (int ind = 1; ind < flowerbed.Length - 1; ind++)
        {
            if (flowerbed[ind] == 0 && flowerbed[ind - 1] == 0 && flowerbed[ind + 1] == 0)
            {
                flowerbed[ind] = 1;
                places += 1;
            }
        }

        if (flowerbed[^1] == 0 && flowerbed[^2] == 0)
        {
            flowerbed[^1] = 1;
            places += 1;
        }

        return places >= n;
    }
}
