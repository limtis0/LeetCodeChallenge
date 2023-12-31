namespace LeetCodeChallenge;

[TestClass]
public class TestPacificAtlanticWaterFlow
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        int[][] heights = new int[][]
        {
            new int[] { 1, 2, 2, 3, 5 },
            new int[] { 3, 2, 3, 4, 4 },
            new int[] { 2, 4, 5, 3, 1 },
            new int[] { 6, 7, 1, 4, 5 },
            new int[] { 5, 1, 1, 2, 4 }
        };

        List<List<int>> expected = new()
        {
            new() { 0, 4 },
            new() { 1, 3 },
            new() { 1, 4 },
            new() { 2, 2 },
            new() { 3, 0 },
            new() { 3, 1 },
            new() { 4, 0 }
        };

        // Act
        var actual = PacificAtlanticWaterFlow.PacificAtlantic(heights);

        // Assert
        Assert.IsTrue(expected.Zip(actual, (e, a) => a.SequenceEqual(e)).All(b => b));
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        int[][] heights = new int[][]
        {
            new int[] { 1 }
        };

        List<List<int>> expected = new()
        {
            new() { 0, 0 }
        };

        // Act
        var actual = PacificAtlanticWaterFlow.PacificAtlantic(heights);

        // Assert
        Assert.IsTrue(expected.Zip(actual, (e, a) => a.SequenceEqual(e)).All(b => b));
    }
}
