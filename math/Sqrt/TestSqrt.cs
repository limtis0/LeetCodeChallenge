namespace LeetCodeChallenge;

[TestClass]
public class TestSqrt
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        int x = 4;
        
        int expected = 2;

        // Act
        int actual = Sqrt.MySqrt(x);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        int x = 0;
        
        int expected = 0;

        // Act
        int actual = Sqrt.MySqrt(x);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test3()
    {
        // Arrange
        int x = 1;
        
        int expected = 1;

        // Act
        int actual = Sqrt.MySqrt(x);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test4()
    {
        // Arrange
        int x = 8;
        
        int expected = 2;

        // Act
        int actual = Sqrt.MySqrt(x);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test5()
    {
        // Arrange
        int x = 2147395599;
        
        int expected = 46339;

        // Act
        int actual = Sqrt.MySqrt(x);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
