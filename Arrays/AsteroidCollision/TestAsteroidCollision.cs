namespace LeetCodeChallenge;

[TestClass]
public class TestAsteroidCollision
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        int[] asteroids = new[] { 5, 10, -5 };

        int[] expected = new[] { 5, 10 };

        // Act
        int[] actual = AsteroidCollision.Solution(asteroids);

        // Assert
        Assert.IsTrue(expected.SequenceEqual(actual));
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        int[] asteroids = new[] { 8, -8 };

        int[] expected = Array.Empty<int>();

        // Act
        int[] actual = AsteroidCollision.Solution(asteroids);

        // Assert
        Assert.IsTrue(expected.SequenceEqual(actual));
    }

    [TestMethod]
    public void Test3()
    {
        // Arrange
        int[] asteroids = new[] { 10, 2, -5 };

        int[] expected = new[] { 10 };

        // Act
        int[] actual = AsteroidCollision.Solution(asteroids);

        // Assert
        Assert.IsTrue(expected.SequenceEqual(actual));
    }

    [TestMethod]
    public void Test4()
    {
        // Arrange
        int[] asteroids = new[] { -2, -1, 1, 2 };

        int[] expected = new[] { -2, -1, 1, 2 };

        // Act
        int[] actual = AsteroidCollision.Solution(asteroids);

        // Assert
        Assert.IsTrue(expected.SequenceEqual(actual));
    }

    [TestMethod]
    public void Test5()
    {
        // Arrange
        int[] asteroids = new[] { 1, -2, -2, -2 };

        int[] expected = new[] { -2, -2, -2 };

        // Act
        int[] actual = AsteroidCollision.Solution(asteroids);

        // Assert
        Assert.IsTrue(expected.SequenceEqual(actual));
    }
}
