namespace LeetCodeChallenge;

[TestClass]
public class TestStringCompression
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        char[] chars = new[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' };

        char[] expected = new[] { 'a', '2', 'b', '2', 'c', '3' };

        // Act
        int actual = StringCompression.Compress(chars);

        // Assert
        Assert.AreEqual(expected.Length, actual);
        Assert.IsTrue(expected.SequenceEqual(chars[..expected.Length]));
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        char[] chars = new[] { 'a' };

        char[] expected = new[] { 'a' };

        // Act
        int actual = StringCompression.Compress(chars);

        // Assert
        Assert.AreEqual(expected.Length, actual);
        Assert.IsTrue(expected.SequenceEqual(chars[..expected.Length]));
    }

    [TestMethod]
    public void Test3()
    {
        // Arrange
        char[] chars = new[] { 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b' };

        char[] expected = new[] { 'a', 'b', '1', '2' };

        // Act
        int actual = StringCompression.Compress(chars);

        // Assert
        Assert.AreEqual(expected.Length, actual);
        Assert.IsTrue(expected.SequenceEqual(chars[..expected.Length]));
    }

    [TestMethod]
    public void Test4()
    {
        // Arrange
        char[] chars = new[] { 'a', 'b', 'c' };

        char[] expected = new[] { 'a', 'b', 'c' };

        // Act
        int actual = StringCompression.Compress(chars);

        // Assert
        Assert.AreEqual(expected.Length, actual);
        Assert.IsTrue(expected.SequenceEqual(chars[..expected.Length]));
    }
}
