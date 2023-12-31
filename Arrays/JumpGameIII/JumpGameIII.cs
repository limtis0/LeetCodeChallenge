using System.Collections;

namespace LeetCodeChallenge;

// 1306. https://leetcode.com/problems/jump-game-iii/
public class JumpGameIII
{
    public static bool CanReach(int[] arr, int start) 
    {
        BitArray memo = new(arr.Length);

        return Recursive(arr, start, memo);
    }

    private static bool Recursive(int[] arr, int index, BitArray memo)
    {
        if (index < 0 || index >= arr.Length || memo.Get(index))
        {
            return false;
        }

        int val = arr[index];

        if (val == 0)
        {
            return true;
        }

        memo.Set(index, true);

        return Recursive(arr, index + val, memo) || Recursive(arr, index - val, memo);
    }
}
