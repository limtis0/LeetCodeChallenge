namespace LeetCodeChallenge;

[TestClass]
public class TestHighestAltitude
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        int[] gain = { -5, 1, 5, 0, -7 };
        int expected = 1;

        // Act
        var actual = HighestAltitude.LargestAltitude(gain);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        int[] gain = { -4, -3, -2, -1, 4, 3, 2 };
        int expected = 0;

        // Act
        var actual = HighestAltitude.LargestAltitude(gain);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
