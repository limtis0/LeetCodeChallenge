namespace LeetCodeChallenge;

[TestClass]
public class TestShift2DGrid
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        int[][] grid = new int[][]
        {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 },
            new int[] { 7, 8, 9 }
        };

        int k = 1;

        List<List<int>> expected =
            new()
            {
                new List<int>() { 9, 1, 2 },
                new List<int>() { 3, 4, 5 },
                new List<int>() { 6, 7, 8 },
            };

        // Act
        var actual = Shift2DGrid.ShiftGrid(grid, k);

        // Assert
        for (int i = 0; i < expected.Count; i++)
        {
            Assert.IsTrue(expected[i].SequenceEqual(actual[i]));
        }
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        int[][] grid = new int[][]
        {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 },
            new int[] { 7, 8, 9 }
        };

        int k = 4;

        List<List<int>> expected =
            new()
            {
                new List<int>() { 6, 7, 8 },
                new List<int>() { 9, 1, 2 },
                new List<int>() { 3, 4, 5 },
            };

        // Act
        var actual = Shift2DGrid.ShiftGrid(grid, k);

        // Assert
        for (int i = 0; i < expected.Count; i++)
        {
            Assert.IsTrue(expected[i].SequenceEqual(actual[i]));
        }
    }
}
