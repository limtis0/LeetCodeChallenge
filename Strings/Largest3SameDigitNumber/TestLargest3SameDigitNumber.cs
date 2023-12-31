namespace LeetCodeChallenge;

[TestClass]
public class TestLargest3SameDigitNumber
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        string num = "6777133339";
        
        string expected = "777";

        // Act
        string actual = Largest3SameDigitNumber.Solution(num);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        string num = "2300019";
        
        string expected = "000";

        // Act
        string actual = Largest3SameDigitNumber.Solution(num);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test3()
    {
        // Arrange
        string num = "42352338";
        
        string expected = string.Empty;

        // Act
        string actual = Largest3SameDigitNumber.Solution(num);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
