namespace LeetCodeChallenge;

[TestClass]
public class TestTwoSum
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        int[] expected = { 0, 1 };

        // Act
        int[] actual = TwoSum.Solution(nums, target);

        // Assert
        Assert.IsTrue(expected.SequenceEqual(actual));
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        int[] nums = { 3, 2, 4 };
        int target = 6;

        int[] expected = { 1, 2 };

        // Act
        int[] actual = TwoSum.Solution(nums, target);

        // Assert
        Assert.IsTrue(expected.SequenceEqual(actual));
    }
}
