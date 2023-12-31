namespace LeetCodeChallenge;

[TestClass]
public class TestNthTribonacciNumber
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        int param = 4;
        
        int expected = 4;

        // Act
        int actual = NthTribonacciNumber.Tribonacci(param);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        int param = 25;
        
        int expected = 1389537;

        // Act
        int actual = NthTribonacciNumber.Tribonacci(param);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
