namespace LeetCodeChallenge;

public class MaxAverageSubarray {
    public static double FindMaxAverage(int[] nums, int k) {
        int currentSum = nums[..k].Sum();
        double maxSum = currentSum;

        for (int ind = 1; ind <= nums.Length - k; ind++) {
            currentSum = currentSum - nums[ind - 1] + nums[ind + k - 1];
            maxSum = Math.Max(maxSum, currentSum);
        }

        return maxSum / k;
    }
}