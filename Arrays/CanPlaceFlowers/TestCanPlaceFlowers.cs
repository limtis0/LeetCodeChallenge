namespace LeetCodeChallenge;

[TestClass]
public class TestCanPlaceFlowers
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        int[] flowerbed = { 1, 0, 0, 0, 1 };
        int n = 1;
        bool expected = true;

        // Act
        var actual = CanPlaceFlowers.Solution(flowerbed, n);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        int[] flowerbed = { 1, 0, 0, 0, 1 };
        int n = 2;
        bool expected = false;

        // Act
        var actual = CanPlaceFlowers.Solution(flowerbed, n);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
