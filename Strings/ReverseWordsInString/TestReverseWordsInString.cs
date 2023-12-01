namespace LeetCodeChallenge;

[TestClass]
public class TestReverseWordsInString
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        string s = "the sky is blue";
        string expected = "blue is sky the";

        // Act
        string actual = ReverseWordsInString.Reverse(s);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        string s = "  hello world  ";
        string expected = "world hello";

        // Act
        string actual = ReverseWordsInString.Reverse(s);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test3()
    {
        // Arrange
        string s = "a good   example";
        string expected = "example good a";

        // Act
        string actual = ReverseWordsInString.Reverse(s);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
