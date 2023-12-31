namespace LeetCodeChallenge;

[TestClass]
public class TestIntegerToRoman
{
    [TestMethod]
    [DataRow(3, "III")]
    [DataRow(58, "LVIII")]
    [DataRow(1994, "MCMXCIV")]
    public void Test1(int num, string expected)
    {
        // Act
        string actual = IntegerToRoman.IntToRoman(num);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
