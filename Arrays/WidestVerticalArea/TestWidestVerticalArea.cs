namespace LeetCodeChallenge;

[TestClass]
public class TestWidestVerticalArea
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        int[][] points =
        {
            new int[] { 8, 7 },
            new int[] { 9, 9 },
            new int[] { 7, 4 },
            new int[] { 9, 7 },
        };

        int expected = 1;

        // Act
        int actual = WidestVerticalArea.MaxWidthOfVerticalArea(points);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        int[][] points =
        {
            new int[] { 3, 1 },
            new int[] { 9, 0 },
            new int[] { 1, 0 },
            new int[] { 1, 4 },
            new int[] { 5, 3 },
            new int[] { 8, 8 },
        };

        int expected = 3;

        // Act
        int actual = WidestVerticalArea.MaxWidthOfVerticalArea(points);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
