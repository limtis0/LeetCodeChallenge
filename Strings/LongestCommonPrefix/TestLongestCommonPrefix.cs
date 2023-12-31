namespace LeetCodeChallenge;

[TestClass]
public class TestLongestCommonPrefix
{
    [TestMethod]
    [DataRow(new string[] { "flower", "flow", "flight" }, "fl")]
    [DataRow(new string[] { "dog", "racecar", "car" }, "")]
    public void Test1(string[] strs, string expected)
    {
        // Act
        string actual = LongestCommonPrefix.SolutionVertical(strs);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
