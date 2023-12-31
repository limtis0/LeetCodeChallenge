namespace LeetCodeChallenge;

[TestClass]
public class TestTripletSubsequence
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        int[] nums = new[] { 1, 2, 3, 4, 5 };

        bool expected = true;

        // Act
        bool actual = TripletSubsequence.Exists(nums);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        int[] nums = new[] { 5, 4, 3, 2, 1 };

        bool expected = false;

        // Act
        bool actual = TripletSubsequence.Exists(nums);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test3()
    {
        // Arrange
        int[] nums = new[] { 2, 1, 5, 0, 4, 6 };

        bool expected = true;

        // Act
        bool actual = TripletSubsequence.Exists(nums);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test4()
    {
        // Arrange
        int[] nums = new[] { 20, 100, 10, 12, 5, 13 };

        bool expected = true;

        // Act
        bool actual = TripletSubsequence.Exists(nums);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test5()
    {
        // Arrange
        int[] nums = new[] { 1, 2 };

        bool expected = false;

        // Act
        bool actual = TripletSubsequence.Exists(nums);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
