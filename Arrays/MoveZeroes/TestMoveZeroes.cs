namespace LeetCodeChallenge;

[TestClass]
public class TestMoveZeroes
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        int[] nums = { 0, 1, 0, 3, 12 };
        int[] expected = { 1, 3, 12, 0, 0 };

        // Act
        MoveZeroes.Solution(nums);

        // Assert
        Assert.IsTrue(nums.SequenceEqual(expected));
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        int[] nums = { 0 };
        int[] expected = { 0 };

        // Act
        MoveZeroes.Solution(nums);

        // Assert
        Assert.IsTrue(nums.SequenceEqual(expected));
    }

    [TestMethod]
    public void Test3()
    {
        // Arrange
        int[] nums = { 1 };
        int[] expected = { 1 };

        // Act
        MoveZeroes.Solution(nums);

        // Assert
        Assert.IsTrue(nums.SequenceEqual(expected));
    }
}
