namespace LeetCodeChallenge;

[TestClass]
public class TestLargestOddNumber
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        string num = "52";
        
        string expected = "5";

        // Act
        string actual = LargestOddNumber.Solution(num);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        string num = "4206";
        
        string expected = string.Empty;

        // Act
        string actual = LargestOddNumber.Solution(num);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test3()
    {
        // Arrange
        string num = "35427";
        
        string expected = "35427";

        // Act
        string actual = LargestOddNumber.Solution(num);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
