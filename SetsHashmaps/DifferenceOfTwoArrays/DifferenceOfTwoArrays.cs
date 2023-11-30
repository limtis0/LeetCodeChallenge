namespace LeetCodeChallenge;

// 2215. https://leetcode.com/problems/find-the-difference-of-two-arrays/
public class DifferenceOfTwoArrays
{
    public static IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        HashSet<int> set1 = new(nums1);
        HashSet<int> set2 = new(nums2);

        set1.ExceptWith(nums2);
        set2.ExceptWith(nums1);

        return new List<IList<int>>() { set1.ToList(), set2.ToList() };
    }
}
