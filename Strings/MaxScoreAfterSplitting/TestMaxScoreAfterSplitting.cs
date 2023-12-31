namespace LeetCodeChallenge;

[TestClass]
public class TestMaxScoreAfterSplitting
{
    [TestMethod]
    [DataRow("011101", 5)]
    [DataRow("00111", 5)]
    [DataRow("1111", 3)]
    [DataRow("1011011", 5)]
    public void Test1(string s, int expected)
    {
        // Act
        int actual = MaxScoreAfterSplitting.MaxScore(s);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
