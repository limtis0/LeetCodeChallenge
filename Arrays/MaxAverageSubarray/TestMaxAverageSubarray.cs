namespace LeetCodeChallenge;

[TestClass]
public class TestMaxAverageSubarray
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        int[] nums = { 1,12,-5,-6,50,3 };
        int k = 4;
        double expected = 12.75;

        // Act
        var actual = MaxAverageSubarray.FindMaxAverage(nums, k);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        int[] nums = { 5 };
        int k = 1;
        double expected = 5;

        // Act
        var actual = MaxAverageSubarray.FindMaxAverage(nums, k);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
