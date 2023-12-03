namespace LeetCodeChallenge;

[TestClass]
public class TestSingleNumber
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        int[] nums = { 2, 2, 1 };
        int expected = 1;

        // Act
        int actual = SingleNumber.Find(nums);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        int[] nums = { 4, 1, 2, 1, 2 };
        int expected = 4;

        // Act
        int actual = SingleNumber.Find(nums);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test3()
    {
        // Arrange
        int[] nums = { 1 };
        int expected = 1;

        // Act
        int actual = SingleNumber.Find(nums);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
