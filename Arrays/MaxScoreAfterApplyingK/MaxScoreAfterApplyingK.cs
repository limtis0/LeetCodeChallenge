namespace LeetCodeChallenge;

// 2530. https://leetcode.com/problems/maximal-score-after-applying-k-operations/
public class MaxScoreAfterApplyingK
{
    public static long MaxKelements(int[] nums, int k)
    {
        PriorityQueue<int, int> pq = new(nums.Length);

        foreach (int num in nums)
        {
            pq.Enqueue(num, -num);
        }

        long sum = 0;

        while (k > 0)
        {
            int current = pq.Dequeue();
            sum += current;

            current = (current + 2) / 3;
            pq.Enqueue(current, -current);

            k--;
        }

        return sum;
    }
}
