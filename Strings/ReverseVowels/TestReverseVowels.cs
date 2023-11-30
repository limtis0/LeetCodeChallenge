namespace LeetCodeChallenge;

[TestClass]
public class TestReverseVowels
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        string s = "hello";
        string expected = "holle";

        // Act
        string actual = ReverseVowels.Reverse(s);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        string s = "leetcode";
        string expected = "leotcede";

        // Act
        string actual = ReverseVowels.Reverse(s);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test3()
    {
        // Arrange
        string s = "aA";
        string expected = "Aa";

        // Act
        string actual = ReverseVowels.Reverse(s);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
