namespace LeetCodeChallenge;

[TestClass]
public class TestWordsFormedByCharacters
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        string[] words = new[] {"cat","bt","hat","tree"};
        string chars = "atach";
        
        int expected = 6;

        // Act
        int actual = WordsFormedByCharacters.CountCharacters(words, chars);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        string[] words = new[] {"hello","world","leetcode"};
        string chars = "welldonehoneyr";
        
        int expected = 10;

        // Act
        int actual = WordsFormedByCharacters.CountCharacters(words, chars);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
