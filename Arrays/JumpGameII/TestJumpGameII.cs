namespace LeetCodeChallenge;

[TestClass]
public class TestJumpGameII
{
    [TestMethod]
    [DataRow(new int[] { 2, 3, 1, 1, 4 }, 2)]
    [DataRow(new int[] { 2, 3, 0, 1, 4 }, 2)]
    [DataRow(new int[] { 3, 1, 4, 2, 5, 7, 2, 4, 8, 1 }, 3)]
    public void Tests(int[] nums, int expected)
    {
        // Act
        int actual = JumpGameII.Jump(nums);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
