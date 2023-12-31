namespace LeetCodeChallenge;

[TestClass]
public class TestLongestIncreasingSubsequence
{
    private static IEnumerable<object[]> TestData =>
        new List<object[]>
        {
            new object[] { new int[] { 10, 9, 2, 5, 3, 7, 101, 18 }, 4 },
            new object[] { new int[] { 0, 1, 0, 3, 2, 3 }, 4 },
            new object[] { new int[] { 7, 7, 7, 7, 7, 7, 7 }, 1 }
        };

    [TestMethod]
    [DynamicData(nameof(TestData))]
    public void Tests(int[] nums, int expected)
    {
        // Act
        int actual = LongestIncreasingSubsequence.LengthOfLIS(nums);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
