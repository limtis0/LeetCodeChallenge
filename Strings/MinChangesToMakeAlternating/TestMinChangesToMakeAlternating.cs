namespace LeetCodeChallenge;

[TestClass]
public class TestMinChangesToMakeAlternating
{
    [TestMethod]
    [DataRow("0100", 1)]
    [DataRow("101", 0)]
    [DataRow("1111", 2)]
    [DataRow("10100101010", 4)]
    public void Tests(string s, int expected)
    {
        // Act
        int actual = MinChangesToMakeAlternating.MinOperations(s);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
