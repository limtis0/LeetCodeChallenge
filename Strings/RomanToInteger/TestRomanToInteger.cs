namespace LeetCodeChallenge;

[TestClass]
public class TestRomanToInteger
{
    [TestMethod]
    [DataRow("III", 3)]
    [DataRow("LVIII", 58)]
    [DataRow("MCMXCIV", 1994)]
    public void Test1(string s, int expected)
    {
        // Act
        int actual = RomanToInteger.RomanToInt(s);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
