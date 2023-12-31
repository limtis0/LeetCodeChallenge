namespace LeetCodeChallenge;

[TestClass]
public class TestRemoveStarsFromString
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        string s = "leet**cod*e";
        
        string expected = "lecoe";

        // Act
        string actual = RemoveStarsFromString.RemoveStars(s);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        string s = "erase*****";
        
        string expected = string.Empty;

        // Act
        string actual = RemoveStarsFromString.RemoveStars(s);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
