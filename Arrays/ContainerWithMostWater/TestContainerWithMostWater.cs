namespace LeetCodeChallenge;

[TestClass]
public class TestContainerWithMostWater
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        int[] height = new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };

        int expected = 49;

        // Act
        int actual = ContainerWithMostWater.MaxArea(height);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        int[] height = new[] { 1, 1 };

        int expected = 1;

        // Act
        int actual = ContainerWithMostWater.MaxArea(height);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
