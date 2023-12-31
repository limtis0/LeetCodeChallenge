namespace LeetCodeChallenge;

[TestClass]
public class TestTransposeMatrix
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        int[][] matrix = new int[][] {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 },
            new int[] { 7, 8, 9 },
        };
        
        int[][] expected = new int[][] {
            new int[] { 1, 4, 7 },
            new int[] { 2, 5, 8 },
            new int[] { 3, 6, 9 },
        };;

        // Act
        int[][] actual = TransposeMatrix.Transpose(matrix);

        // Assert
        Assert.IsTrue(expected.Zip(actual, (e, a) => e.SequenceEqual(a)).All(x => x));
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        int[][] matrix = new int[][] {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 },
        };
        
        int[][] expected = new int[][] {
            new int[] { 1, 4 },
            new int[] { 2, 5 },
            new int[] { 3, 6 },
        };;

        // Act
        int[][] actual = TransposeMatrix.Transpose(matrix);

        // Assert
        Assert.IsTrue(expected.Zip(actual, (e, a) => e.SequenceEqual(a)).All(x => x));
    }
}
