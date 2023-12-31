namespace LeetCodeChallenge;

[TestClass]
public class TestZigzagConversion
{
    [TestMethod]
    [DataRow("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
    [DataRow("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
    [DataRow("A", 1, "A")]
    public void Test1(string s, int numRows, string expected)
    {
        // Act
        string actual = ZigzagConversion.Convert(s, numRows);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
