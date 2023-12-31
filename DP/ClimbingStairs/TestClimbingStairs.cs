namespace LeetCodeChallenge;

[TestClass]
public class TestClimbingStairs
{
    [TestMethod]
    [DataRow(2, 2)]
    [DataRow(3, 3)]
    [DataRow(45, 1836311903)]
    public void Tests(int n, int expected)
    {
        // Act
        int actual = ClimbingStairs.ClimbStairs(n);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
