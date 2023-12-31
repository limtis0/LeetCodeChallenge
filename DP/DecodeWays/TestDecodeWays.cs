namespace LeetCodeChallenge;

[TestClass]
public class TestDecodeWays
{
    [TestMethod]
    [DataRow("12", 2)]
    [DataRow("226", 3)]
    [DataRow("06", 0)]
    [DataRow("0", 0)]
    [DataRow("1234321", 6)]
    public void Test1(string s, int expected)
    {
        // Act
        int actual = DecodeWays.NumDecodings(s);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
