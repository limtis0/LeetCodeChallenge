namespace LeetCodeChallenge;

[TestClass]
public class TestPathCrossing
{
    [TestMethod]
    [DataRow("NES", false)]
    [DataRow("NESWW", true)]
    public void Test1(string path, bool expected)
    {
        // Act
        bool actual = PathCrossing.IsPathCrossing(path);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
