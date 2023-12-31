namespace LeetCodeChallenge;

[TestClass]
public class TestMinimumConsecutiveCards
{
    [TestMethod]
    [DataRow(new int[] { 3, 4, 2, 3, 4, 7 }, 4)]
    [DataRow(new int[] { 1, 0, 5, 3 }, -1)]
    public void Test1(int[] cards, int expected)
    {
        // Act
        int actual = MinimumConsecutiveCards.MinimumCardPickup(cards);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}