namespace LeetCodeChallenge;

// 1335. https://leetcode.com/problems/minimum-difficulty-of-a-job-schedule/
public class MinimumDifficultyJobSchedule
{
    public static int MinDifficulty(int[] jobDifficulty, int dayCount)
    {
        int jobsLength = jobDifficulty.Length;

        if (dayCount > jobsLength)
        {
            return -1;
        }

        int[,] dp = new int[dayCount, jobsLength];

        dp[0, 0] = jobDifficulty[0];

        // Initialize the first day
        for (int i = 1; i < jobsLength; i++)
        {
            dp[0, i] = Math.Max(dp[0, i - 1], jobDifficulty[i]);
        }

        // Starting from the second day
        for (int curDay = 1; curDay < dayCount; curDay++)
        {
            // Setting the job limit for current day
            for (int jobLim = curDay; jobLim < jobsLength; jobLim++)
            {
                dp[curDay, jobLim] = int.MaxValue;

                int maxDifficulty = 0;

                for (int jobInd = jobLim; jobInd >= curDay; jobInd--)
                {
                    maxDifficulty = Math.Max(maxDifficulty, jobDifficulty[jobInd]);

                    dp[curDay, jobLim] = Math.Min(dp[curDay, jobLim], dp[curDay - 1, jobInd - 1] + maxDifficulty);
                }
            }
        }

        return dp[dayCount - 1, jobsLength - 1];
    }

    public static int MinDifficultyRecursive(int[] jobDifficulty, int d)
    {
        if (d > jobDifficulty.Length)
        {
            return -1;
        }

        Dictionary<(int currentIndex, int daysLeft, int maxDay), int> memo = new();

        int DP(int currentIndex, int daysLeft, int maxDay = -1)
        {
            if (daysLeft > jobDifficulty.Length - currentIndex)
            {
                return int.MaxValue;
            }

            var memoKey = (currentIndex, daysLeft, maxDay);

            if (memo.TryGetValue(memoKey, out int cached))
            {
                return cached;
            }

            maxDay = Math.Max(maxDay, jobDifficulty[currentIndex]);

            if (currentIndex == jobDifficulty.Length - 1)
            {
                return maxDay;
            }

            int takeJobToday = DP(currentIndex + 1, daysLeft, maxDay);
            int nextDay = DP(currentIndex + 1, daysLeft - 1);

            int result = Math.Min(takeJobToday, maxDay + nextDay);

            memo[memoKey] = result;

            return result;
        }

        return DP(0, d);
    }
}
