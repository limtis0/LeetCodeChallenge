namespace LeetCodeChallenge;

[TestClass]
public class TestMinimumDifficultyJobSchedule
{
    [TestMethod]
    [DataRow(new int[] { 6, 5, 4, 3, 2, 1 }, 2, 7)]
    [DataRow(new int[] { 9, 9, 9 }, 4, -1)]
    [DataRow(new int[] { 1, 1, 1 }, 3, 3)]
    [DataRow(new int[] { 11, 111, 22, 222, 33, 333, 44, 444 }, 6, 843)]
    public void Tests(int[] jobDifficulty, int d, int expected)
    {
        // Act
        int actual = MinimumDifficultyJobSchedule.MinDifficulty(jobDifficulty, d);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
