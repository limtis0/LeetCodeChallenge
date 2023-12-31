namespace LeetCodeChallenge;

[TestClass]
public class TestJumpGame
{
    [TestMethod]
    [DataRow(new int[] { 2, 3, 1, 1, 4 }, true)]
    [DataRow(new int[] { 3, 2, 1, 0, 4 }, false)]
    [DataRow(new int[] { 3, 2, 3, 0, 4 }, true)]
    public void Tests(int[] nums, bool expected)
    {
        // Act
        bool actual = JumpGame.CanJump(nums);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
