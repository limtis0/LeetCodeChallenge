namespace LeetCodeChallenge;

[TestClass]
public class TestArrayStringsAreEqual
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        string[] word1 = new[] { "ab", "c" };
        string[] word2 = new[] { "a", "bc" };

        bool expected = true;

        // Act
        var actual = ArrayStringsAreEqual.Solution(word1, word2);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        string[] word1 = new[] { "ac", "b" };
        string[] word2 = new[] { "ab", "c" };

        bool expected = false;

        // Act
        var actual = ArrayStringsAreEqual.Solution(word1, word2);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test3()
    {
        // Arrange
        string[] word1 = new[] { "abc", "d", "defg" };
        string[] word2 = new[] { "abcddefg" };

        bool expected = true;

        // Act
        var actual = ArrayStringsAreEqual.Solution(word1, word2);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}