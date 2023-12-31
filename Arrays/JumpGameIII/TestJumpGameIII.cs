namespace LeetCodeChallenge;

[TestClass]
public class TestJumpGameIII
{
    [TestMethod]
    [DataRow(new int[] { 4, 2, 3, 0, 3, 1, 2 }, 5, true)]
    [DataRow(new int[] { 4, 2, 3, 0, 3, 1, 2 }, 0, true)]
    [DataRow(new int[] { 3, 0, 2, 1, 2 }, 2, false)]
    public void Tests(int[] arr, int start, bool expected)
    {
        // Act
        bool actual = JumpGameIII.CanReach(arr, start);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
