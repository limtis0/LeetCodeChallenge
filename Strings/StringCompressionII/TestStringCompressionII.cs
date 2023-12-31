namespace LeetCodeChallenge;

[TestClass]
public class TestStringCompressionII
{
    [TestMethod]
    [DataRow("aaabcccd", 2, 4)]
    [DataRow("aabbaa", 2, 2)]
    [DataRow("aaaaaaaaaaa", 0, 3)]
    public void Test1(string s, int k, int expected)
    {
        // Act
        int actual = StringCompressionII.GetLengthOfOptimalCompression(s, k);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
