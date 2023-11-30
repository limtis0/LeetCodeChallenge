namespace LeetCodeChallenge;

[TestClass]
public class TestUniqueNumberOccurencies
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        int[] arr = {1,2,2,1,1,3};
        bool expected = true;

        // Act
        bool actual = UniqueOccurrences.IsUnique(arr);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        int[] arr = {-3,0,1,-3,1,1,1,-3,10,0};
        bool expected = true;

        // Act
        bool actual = UniqueOccurrences.IsUnique(arr);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test3()
    {
        // Arrange
        int[] arr = {1, 2};
        bool expected = false;

        // Act
        bool actual = UniqueOccurrences.IsUnique(arr);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
