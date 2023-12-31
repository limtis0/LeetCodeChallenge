namespace LeetCodeChallenge;

[TestClass]
public class TestFirstCompletelyPaintedRowOrCol
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        int[] arr = new int[] { 1, 4, 5, 2, 6, 3 };
        int[][] mat = new int[][] { new int[] { 4, 3, 5 }, new int[] { 1, 2, 6 } };

        int expected = 1;

        // Act
        int actual = FirstCompletelyPaintedRowOrCol.FirstCompleteIndex(arr, mat);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
