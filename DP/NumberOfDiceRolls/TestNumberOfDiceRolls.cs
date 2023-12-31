namespace LeetCodeChallenge;

[TestClass]
public class TestNumberOfDiceRolls
{
    [TestMethod]
    [DataRow(1, 6, 3, 1)]
    [DataRow(2, 6, 7, 6)]
    [DataRow(30, 30, 500, 222616187)]
    public void Tests(int n, int k, int target, int expected)
    {
        // Act
        int actual = NumberOfDiceRolls.NumRollsToTarget(n, k, target);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
