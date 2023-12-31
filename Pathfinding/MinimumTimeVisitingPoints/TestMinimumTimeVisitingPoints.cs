namespace LeetCodeChallenge;

[TestClass]
public class TestMinimumTimeVisitingPoints
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        int[][] points = new[] { new[] { 1, 1 }, new[] { 3, 4 }, new[] { -1, 0 }, };

        int expected = 7;

        // Act
        int actual = MinimumTimeVisitingPoints.Solution(points);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
