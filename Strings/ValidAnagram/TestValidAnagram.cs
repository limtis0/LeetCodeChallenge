namespace LeetCodeChallenge;

[TestClass]
public class TestValidAnagram
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        string s = "anagram";
        string t = "nagaram";
        
        bool expected = true;

        // Act
        bool actual = ValidAnagram.IsAnagram(s, t);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        string s = "rat";
        string t = "car";
        
        bool expected = false;

        // Act
        bool actual = ValidAnagram.IsAnagram(s, t);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
