namespace LeetCodeChallenge;

[TestClass]
public class TestTextJustification
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        string[] words = { "This", "is", "an", "example", "of", "text", "justification." };

        int maxWidth = 16;

        string[] expected = { "This    is    an", "example  of text", "justification.  " };

        // Act
        var actual = TextJustification.FullJustify(words, maxWidth);

        // Assert
        Assert.IsTrue(expected.SequenceEqual(actual));
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        string[] words = { "What", "must", "be", "acknowledgment", "shall", "be" };

        int maxWidth = 16;

        string[] expected = { "What   must   be", "acknowledgment  ", "shall be        " };

        // Act
        var actual = TextJustification.FullJustify(words, maxWidth);

        // Assert
        Assert.IsTrue(expected.SequenceEqual(actual));
    }

    [TestMethod]
    public void Test3()
    {
        // Arrange
        string[] words =
        {
            "Science",
            "is",
            "what",
            "we",
            "understand",
            "well",
            "enough",
            "to",
            "explain",
            "to",
            "a",
            "computer.",
            "Art",
            "is",
            "everything",
            "else",
            "we",
            "do"
        };

        int maxWidth = 20;

        string[] expected =
        {
            "Science  is  what we",
            "understand      well",
            "enough to explain to",
            "a  computer.  Art is",
            "everything  else  we",
            "do                  "
        };

        // Act
        var actual = TextJustification.FullJustify(words, maxWidth);

        // Assert
        Assert.IsTrue(expected.SequenceEqual(actual));
    }

    [TestMethod]
    public void Test4()
    {
        // Arrange
        string[] words =
        {
            "ask",
            "not",
            "what",
            "your",
            "country",
            "can",
            "do",
            "for",
            "you",
            "ask",
            "what",
            "you",
            "can",
            "do",
            "for",
            "your",
            "country"
        };

        int maxWidth = 16;

        string[] expected =
        {
            "ask   not   what",
            "your country can",
            "do  for  you ask",
            "what  you can do",
            "for your country"
        };

        // Act
        var actual = TextJustification.FullJustify(words, maxWidth);

        // Assert
        Assert.IsTrue(expected.SequenceEqual(actual));
    }
}
