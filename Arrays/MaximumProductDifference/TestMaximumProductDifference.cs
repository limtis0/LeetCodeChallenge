namespace LeetCodeChallenge;

[TestClass]
public class TestMaximumProductDifference
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        int[] nums = { 5, 6, 2, 7, 4 };

        int expected = 34;

        // Act
        int actual = MaximumProductDifference.MaxProductDifference(nums);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        int[] nums = { 4, 2, 5, 9, 7, 4, 8 };

        int expected = 64;

        // Act
        int actual = MaximumProductDifference.MaxProductDifference(nums);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
