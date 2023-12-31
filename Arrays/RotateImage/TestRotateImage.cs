namespace LeetCodeChallenge;

[TestClass]
public class TestRotateImage
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        int[][] matrix = { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 }, };

        // Arrange
        int[][] expected = { new int[] { 7, 4, 1 }, new int[] { 8, 5, 2 }, new int[] { 9, 6, 3 }, };

        // Act
        RotateImage.Rotate(matrix);

        // Assert
        Assert.IsTrue(expected.Zip(matrix, (e, m) => e.SequenceEqual(m)).All(b => b));
    }
}
