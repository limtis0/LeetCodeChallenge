namespace LeetCodeChallenge;

[TestClass]
public class TestVowelsInSubstringOfLength
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        string s = "abciiidef";
        int k = 3;
        
        int expected = 3;

        // Act
        int actual = VowelsInSubstringOfLength.MaxVowels(s, k);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        string s = "aeiou";
        int k = 2;
        
        int expected = 2;

        // Act
        int actual = VowelsInSubstringOfLength.MaxVowels(s, k);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test3()
    {
        // Arrange
        string s = "leetcode";
        int k = 3;
        
        int expected = 2;

        // Act
        int actual = VowelsInSubstringOfLength.MaxVowels(s, k);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test4()
    {
        // Arrange
        string s = "tryhard";
        int k = 4;
        
        int expected = 1;

        // Act
        int actual = VowelsInSubstringOfLength.MaxVowels(s, k);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
