namespace LeetCodeChallenge;

[TestClass]
public class TestCloseStrings
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        string word1 = "abc";
        string word2 = "bca";

        bool expected = true;

        // Act
        bool actual = CloseStrings.AreClose(word1, word2);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        string word1 = "a";
        string word2 = "aa";

        bool expected = false;

        // Act
        bool actual = CloseStrings.AreClose(word1, word2);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test3()
    {
        // Arrange
        string word1 = "cabbba";
        string word2 = "abbccc";

        bool expected = true;

        // Act
        bool actual = CloseStrings.AreClose(word1, word2);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test4()
    {
        // Arrange
        string word1 = "cabbba";
        string word2 = "aabbss";

        bool expected = false;

        // Act
        bool actual = CloseStrings.AreClose(word1, word2);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test5()
    {
        // Arrange
        string word1 = "abbzzca";
        string word2 = "babzzcz";

        bool expected = false;

        // Act
        bool actual = CloseStrings.AreClose(word1, word2);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test6()
    {
        // Arrange
        string word1 = "uau";
        string word2 = "ssx";

        bool expected = false;

        // Act
        bool actual = CloseStrings.AreClose(word1, word2);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
