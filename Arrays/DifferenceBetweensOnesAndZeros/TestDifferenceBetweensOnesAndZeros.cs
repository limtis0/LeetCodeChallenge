namespace LeetCodeChallenge;

[TestClass]
public class TestDifferenceBetweensOnesAndZeros
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        int[][] grid = { new int[] { 0, 1, 1 }, new int[] { 1, 0, 1 }, new int[] { 0, 0, 1 } };

        int[][] expected =
        {
            new int[] { 0, 0, 4 },
            new int[] { 0, 0, 4 },
            new int[] { -2, -2, 2 }
        };

        // Act
        int[][] actual = DifferenceBetweensOnesAndZeros.OnesMinusZeros(grid);

        // Assert
        Assert.IsTrue(expected.Zip(actual, (e, a) => e.SequenceEqual(a)).All(b => b));
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        int[][] grid = { new int[] { 1, 1, 1 }, new int[] { 1, 1, 1 } };
        int[][] expected = { new int[] { 5, 5, 5 }, new int[] { 5, 5, 5 }, };

        // Act
        int[][] actual = DifferenceBetweensOnesAndZeros.OnesMinusZeros(grid);

        // Assert
        Assert.IsTrue(expected.Zip(actual, (e, a) => e.SequenceEqual(a)).All(b => b));
    }
}
