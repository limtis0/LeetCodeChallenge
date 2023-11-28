namespace LeetCodeChallenge;

[TestClass]
public class TestGDCStrings
{
    [TestMethod]
    public void TestDoubledString()
    {
        // Arrange
        string x = "ABCABC";
        string y = "ABC";
        string expected = "ABC";

        // Act
        string actual = GCDStrings.FindGDCString(x, y);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestPassing()
    {
        // Arrange
        string x = "ABABAB";
        string y = "ABAB";
        string expected = "AB";

        // Act
        string actual = GCDStrings.FindGDCString(x, y);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestFailing()
    {
        // Arrange
        string x = "LEET";
        string y = "CODE";
        string expected = string.Empty;

        // Act
        string actual = GCDStrings.FindGDCString(x, y);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}