namespace LeetCodeChallenge;

[TestClass]
public class TestKidsWithCandies
{
    [TestMethod]
    public void TestGeneral()
    {
        // Arrange
        int[] candies = { 2, 3, 5, 1, 3 };
        int extraCandies = 3;
        List<bool> expected = new() { true, true, true, false, true };

        // Act
        var actual = KidsWithCandies.Solution(candies, extraCandies);

        // Assert
        Assert.IsTrue(expected.SequenceEqual(actual));
    }

    [TestMethod]
    public void TestOneFalse()
    {
        // Arrange
        int[] candies = { 12, 1, 12 };
        int extraCandies = 10;
        List<bool> expected = new() { true, false, true };

        // Act
        var actual = KidsWithCandies.Solution(candies, extraCandies);

        // Assert
        Assert.IsTrue(expected.SequenceEqual(actual));
    }

    [TestMethod]
    public void TestOneTrue()
    {
        // Arrange
        int[] candies = { 4, 2, 1, 1, 2 };
        int extraCandies = 1;
        List<bool> expected = new() { true, false, false, false, false };

        // Act
        var actual = KidsWithCandies.Solution(candies, extraCandies);

        // Assert
        Assert.IsTrue(expected.SequenceEqual(actual));
    }
}
