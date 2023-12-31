namespace LeetCodeChallenge;

[TestClass]
public class TestPathWithMaximumGold
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        int[][] grid = new[]
        {
            new int[] { 0, 6, 0 },
            new int[] { 5, 8, 7 },
            new int[] { 0, 9, 0 }
        };

        int expected = 24;

        // Act
        int actual = PathWithMaximumGold.GetMaximumGold(grid);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        int[][] grid = new[]
        {
            new int[] { 1, 0, 7 },
            new int[] { 2, 0, 6 },
            new int[] { 3, 4, 5 },
            new int[] { 0, 3, 0 },
            new int[] { 9, 0, 2 },
        };

        int expected = 28;

        // Act
        int actual = PathWithMaximumGold.GetMaximumGold(grid);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test3()
    {
        // Arrange
        int[][] grid = new[]
        {
            new int[] { 1, 0, 7, 0, 0, 0 },
            new int[] { 2, 0, 6, 0, 1, 0 },
            new int[] { 3, 5, 6, 7, 4, 2 },
            new int[] { 4, 3, 1, 0, 2, 0 },
            new int[] { 3, 0, 5, 0, 20, 0 },
        };

        int expected = 60;

        // Act
        int actual = PathWithMaximumGold.GetMaximumGold(grid);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
