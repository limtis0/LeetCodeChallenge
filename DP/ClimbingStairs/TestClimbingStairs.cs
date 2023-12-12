namespace LeetCodeChallenge;

[TestClass]
public class TestClimbingStairs
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        int n = 2;
        
        int expected = 2;

        // Act
        int actual = ClimbingStairs.ClimbStairs(n);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        int n = 3;
        
        int expected = 3;

        // Act
        int actual = ClimbingStairs.ClimbStairs(n);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test3()
    {
        // Arrange
        int n = 4;
        
        int expected = 5;

        // Act
        int actual = ClimbingStairs.ClimbStairs(n);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test4()
    {
        // Arrange
        int n = 45;
        
        int expected = 8;

        // Act
        int actual = ClimbingStairs.ClimbStairs(n);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
