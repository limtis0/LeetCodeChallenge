namespace LeetCodeChallenge;

[TestClass]
public class TestIntegerToRoman
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        int num = 3;
        
        string expected = "III";

        // Act
        string actual = IntegerToRoman.IntToRoman(num);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        int num = 58;
        
        string expected = "LVIII";

        // Act
        string actual = IntegerToRoman.IntToRoman(num);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test3()
    {
        // Arrange
        int num = 1994;
        
        string expected = "MCMXCIV";

        // Act
        string actual = IntegerToRoman.IntToRoman(num);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
