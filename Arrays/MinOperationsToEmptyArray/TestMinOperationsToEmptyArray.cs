namespace LeetCodeChallenge;

[TestClass]
public class TestMinOperationsToEmptyArray
{
    [TestMethod]
    [DataRow(new int[] { 2, 3, 3, 2, 2, 4, 2, 3, 4 }, 4)]
    [DataRow(new int[] { 2, 1, 2, 2, 3, 3 }, -1)]
    public void Tests(int[] nums, int expected)
    {
        // Act
        int actual = MinOperationsToEmptyArray.MinOperations(nums);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
