namespace LeetCodeChallenge;

[TestClass]
public class TestEqualRowAndColumnPairs
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        int[][] grid = new int[][] {
            new int[] { 3, 2, 1 },
            new int[] { 1, 7, 6 },
            new int[] { 2, 7, 7 },
        };
        
        int expected = 1;

        // Act
        int actual = EqualRowAndColumnPairs.EqualPairs(grid);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        int[][] grid = new int[][] {
            new int[] { 3, 1, 2, 2 },
            new int[] { 1, 4, 4, 5 },
            new int[] { 2, 4, 2, 2 },
            new int[] { 2, 4, 2, 2 },
        };
        
        int expected = 3;

        // Act
        int actual = EqualRowAndColumnPairs.EqualPairs(grid);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
