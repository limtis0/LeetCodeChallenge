namespace LeetCodeChallenge;

[TestClass]
public class TestMaximumProductOfTwoElements
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        int[] nums = { 3, 4, 5, 2 };

        int expected = 12;

        // Act
        int actual = MaximumProductOfTwoElements.MaxProduct(nums);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        int[] nums = { 1, 5, 4, 5 };

        int expected = 16;

        // Act
        int actual = MaximumProductOfTwoElements.MaxProduct(nums);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
