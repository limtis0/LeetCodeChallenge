namespace LeetCodeChallenge;

[TestClass]
public class TestMergeStringsAlternatively
{
    [TestMethod]
    public void TestEqualSize()
    {
        // Arrange
        string x = "abc";
        string y = "pqr";
        string expected = "apbqcr";

        // Act
        string actual = MergeStringsAlternatively.MergeAlternatively(x, y);

        // Assert
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void TestDifferentSize()
    {
        // Arrange
        string x = "ab";
        string y = "pqrs";
        string expected = "apbqrs";

        // Act
        string actual = MergeStringsAlternatively.MergeAlternatively(x, y);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestDifferentSize2()
    {
        // Arrange
        string x = "abcd";
        string y = "pq";
        string expected = "apbqcd";

        // Act
        string actual = MergeStringsAlternatively.MergeAlternatively(x, y);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}