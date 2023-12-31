namespace LeetCodeChallenge;

[TestClass]
public class TestSpecialPositionInBinMatrix
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        int[][] mat = { new int[] { 1, 0, 0 }, new int[] { 0, 0, 1 }, new int[] { 1, 0, 0 }, };

        int expected = 1;

        // Act
        int actual = SpecialPositionInBinMatrix.NumSpecial(mat);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        int[][] mat = { new int[] { 1, 0, 0 }, new int[] { 0, 1, 0 }, new int[] { 0, 0, 1 }, };

        int expected = 3;

        // Act
        int actual = SpecialPositionInBinMatrix.NumSpecial(mat);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test3()
    {
        // Arrange
        int[][] mat =
        {
            new int[] { 0, 0, 1, 0 },
            new int[] { 0, 0, 0, 0 },
            new int[] { 0, 0, 0, 0 },
            new int[] { 0, 1, 0, 0 },
        };

        int expected = 2;

        // Act
        int actual = SpecialPositionInBinMatrix.NumSpecial(mat);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
