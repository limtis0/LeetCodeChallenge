namespace LeetCodeChallenge;

[TestClass]
public class TestMoneyInBank
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        int n = 4;
        
        int expected = 10;

        // Act
        int actual = MoneyInBank.TotalMoney(n);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        int n = 10;
        
        int expected = 37;

        // Act
        int actual = MoneyInBank.TotalMoney(n);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test3()
    {
        // Arrange
        int n = 31;
        
        int expected = 172;

        // Act
        int actual = MoneyInBank.TotalMoney(n);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
