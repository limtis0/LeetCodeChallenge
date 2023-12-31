namespace LeetCodeChallenge;

// 658. https://leetcode.com/problems/find-k-closest-elements/
public class FindKClosestElements
{
    public static IList<int> FindClosestElements(int[] arr, int k, int x)
    {
        int left = BinarySearchClosest(arr, x, k);

        return new ArraySegment<int>(arr, left, k);
    }

    private static int BinarySearchClosest(int[] arr, int target, int rangeSize)
    {
        int left = 0;
        int right = arr.Length - rangeSize;
        
        while (left < right)
        {
            int mid = (left + right) / 2;

            if (target - arr[mid] > arr[mid + rangeSize] - target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }

        return left;
    }
}
