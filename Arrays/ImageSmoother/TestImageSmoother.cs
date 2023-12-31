namespace LeetCodeChallenge;

[TestClass]
public class TestImageSmoother
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        int[][] img = {
            new int[] { 100, 200, 100 },
            new int[] { 200, 50, 200 },
            new int[] { 100, 200, 100 },
        };
        
        int[][] expected = {
            new int[] { 137, 141, 137 },
            new int[] { 141, 138, 141 },
            new int[] { 137, 141, 137 },
        };

        // Act
        int[][] actual = ImageSmoother.Solution(img);

        // Assert
        Assert.IsTrue(expected.Zip(actual, (e, a) => e.SequenceEqual(a)).All(b => b));
    }
}
