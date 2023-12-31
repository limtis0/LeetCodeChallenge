namespace LeetCodeChallenge;

[TestClass]
public class TestLargestSubstringBetweenTwoChars
{
    [TestMethod]
    [DataRow("aa", 0)]
    [DataRow("abca", 2)]
    [DataRow("cbzxy", -1)]
    [DataRow("abcdfea", 5)]
    public void Tests(string s, int expected)
    {
        // Act
        int actual = LargestSubstringBetweenTwoChars.MaxLengthBetweenEqualCharacters(s);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
