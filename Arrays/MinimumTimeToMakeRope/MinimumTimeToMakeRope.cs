namespace LeetCodeChallenge;

// 1578. https://leetcode.com/problems/minimum-time-to-make-rope-colorful/
public class MinimumTimeToMakeRope
{
    public static int MinCost(string colors, int[] neededTime)
    {
        char prevColor = '\0';

        int prevTime = 0;
        int totalTime = 0;

        for (int i = 0; i < neededTime.Length; i++)
        {
            if (prevColor != colors[i])
            {
                prevColor = colors[i];
                prevTime = neededTime[i];

                continue;
            }

            int currentTime = neededTime[i];

            if (currentTime > prevTime)
            {
                totalTime += prevTime;
                prevTime = currentTime;
            }
            else
            {
                totalTime += currentTime;
            }
        }

        return totalTime;
    }

    // // This one writes to the original array
    // public static int MinCost(string colors, int[] neededTime)
    // {
    //     int totalTime = 0;

    //     for (int i = 0; i < neededTime.Length - 1; i++)
    //     {
    //         char colorLeft = colors[i];
    //         char colorRight = colors[i + 1];

    //         if (colorLeft != colorRight)
    //         {
    //             continue;
    //         }

    //         int timeLeft = neededTime[i];
    //         int timeRight = neededTime[i + 1];

    //         if (timeLeft <= timeRight)
    //         {
    //             totalTime += timeLeft;
    //         }
    //         else
    //         {
    //             totalTime += timeRight;
    //             neededTime[i + 1] = timeLeft;
    //         }
    //     }

    //     return totalTime;
    // }
}
