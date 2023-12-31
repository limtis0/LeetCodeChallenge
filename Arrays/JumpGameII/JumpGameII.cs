namespace LeetCodeChallenge;

// 45. https://leetcode.com/problems/jump-game-ii/
public class JumpGameII
{
    public static int Jump(int[] nums)
    {
        int furthest = 0;
        int curEnd = 0;
        int jumpCount = 0;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            // Choose the futhest w/ accordance to proximity to the end
            furthest = Math.Max(furthest, nums[i] + i);

            if (i == curEnd)
            {
                curEnd = furthest;
                jumpCount++;

                if (curEnd > nums.Length - 1)
                {
                    return jumpCount;
                }
            }
        }

        return jumpCount;
    }

    // // It is a bit messy, but I just wanted to get the answer right first
    // public static int Jump(int[] nums)
    // {
    //     if (nums.Length == 1)
    //     {
    //         return 0;
    //     }

    //     int jumpCount = 0;
    //     int p = 0;

    //     int maxJump = nums[0];

    //     while (p + maxJump < nums.Length - 1)
    //     {
    //         int furthestPos = 0;
    //         int furthestInd = p;

    //         for (int i = 1; i <= maxJump; i++)
    //         {
    //             int newPos = nums[p + i] + i;  // Choose the biggest w/ accordance to proximity to the end
                
    //             if (newPos > furthestPos)
    //             {
    //                 furthestPos = newPos;
    //                 furthestInd = p + i;
    //             }
    //         }

    //         p = furthestInd;
    //         maxJump = nums[p];
    //         jumpCount++;
    //     }
        
    //     return jumpCount + 1;
    // }
}
