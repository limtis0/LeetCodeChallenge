namespace LeetCodeChallenge;

[TestClass]
public class TestRedistributeCharacters
{
    [TestMethod]
    [DataRow(new string[] { "abc", "aabc", "bc" }, true)]
    [DataRow(new string[] { "a", "b", "c" }, false)]
    [DataRow(new string[] { "ab", "a" }, false)]
    public void Tests(string[] words, bool expected)
    {
        // Act
        bool actual = RedistributeCharacters.MakeEqual(words);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
