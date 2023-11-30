namespace LeetCodeChallenge;

[TestClass]
public class TestDifferenceOfTwoArrays
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        int[] nums1 = { 1, 2, 3 };
        int[] nums2 = { 2, 4, 6 };

        List<IList<int>> expected =
            new()
            {
                new List<int>() { 1, 3 },
                new List<int>() { 4, 6 }
            };

        // Act
        var actual = DifferenceOfTwoArrays.FindDifference(nums1, nums2);

        // Assert
        Assert.IsTrue(expected.Zip(actual).All(ls => ls.First.SequenceEqual(ls.Second)));
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        int[] nums1 = { 1, 2, 3, 3 };
        int[] nums2 = { 1, 1, 2, 2 };

        List<IList<int>> expected =
            new()
            {
                new List<int>() { 3 },
                new List<int>() { }
            };

        // Act
        var actual = DifferenceOfTwoArrays.FindDifference(nums1, nums2);

        // Assert
        Assert.IsTrue(expected.Zip(actual).All(ls => ls.First.SequenceEqual(ls.Second)));
    }
}
