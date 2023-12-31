namespace LeetCodeChallenge;

[TestClass]
public class TestMinimumTimeToMakeRope
{
    [TestMethod]
    [DataRow("abaac", new int[] { 1, 2, 3, 4, 5 }, 3)]
    [DataRow("abc", new int[] { 1, 2, 3 }, 0)]
    [DataRow("aabaa", new int[] { 1, 2, 3, 4, 1 }, 2)]
    public void Tests(string colors, int[] neededTime, int expected)
    {
        // Act
        int actual = MinimumTimeToMakeRope.MinCost(colors, neededTime);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
