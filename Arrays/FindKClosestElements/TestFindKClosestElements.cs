namespace LeetCodeChallenge;

[TestClass]
public class TestFindKClosestElements
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        int[] arr = { 1, 2, 3, 4, 5 };
        int k = 4;
        int x = 3;

        int[] expected = { 1, 2, 3, 4 };

        // Act
        var actual = FindKClosestElements.FindClosestElements(arr, k, x);

        // Assert
        Assert.IsTrue(expected.SequenceEqual(actual));
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        int[] arr = { 1, 2, 3, 4, 5 };
        int k = 3;
        int x = 6;

        int[] expected = { 3, 4, 5 };

        // Act
        var actual = FindKClosestElements.FindClosestElements(arr, k, x);

        // Assert
        Assert.IsTrue(expected.SequenceEqual(actual));
    }

    [TestMethod]
    public void Test3()
    {
        // Arrange
        int[] arr = { 1, 2, 3, 4, 5 };
        int k = 4;
        int x = -1;

        int[] expected = { 1, 2, 3, 4 };

        // Act
        var actual = FindKClosestElements.FindClosestElements(arr, k, x);

        // Assert
        Assert.IsTrue(expected.SequenceEqual(actual));
    }

    [TestMethod]
    public void Test4()
    {
        // Arrange
        int[] arr = { 0, 0, 1, 2, 3, 3, 4, 7, 7, 8 };
        int k = 3;
        int x = 5;

        int[] expected = { 3, 3, 4 };

        // Act
        var actual = FindKClosestElements.FindClosestElements(arr, k, x);

        // Assert
        Assert.IsTrue(expected.SequenceEqual(actual));
    }

    [TestMethod]
    public void Test5()
    {
        // Arrange
        int[] arr = { 1, 3 };
        int k = 1;
        int x = 2;

        int[] expected = { 1 };

        // Act
        var actual = FindKClosestElements.FindClosestElements(arr, k, x);

        // Assert
        Assert.IsTrue(expected.SequenceEqual(actual));
    }
}
