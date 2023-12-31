namespace LeetCodeChallenge;

[TestClass]
public class TestSortColors
{
    [TestMethod]
    [DataRow(new int[] { 2, 0, 2, 1, 1, 0 })]
    [DataRow(new int[] { 2, 0, 1 })]
    public void Tests(int[] nums)
    {
        // Arrange
        int[] numsCopy = new int[nums.Length];
        Array.Copy(nums, numsCopy, nums.Length);

        // Act
        SortColors.Solution(nums);

        // Assert
        Assert.IsTrue(numsCopy.OrderBy(x => x).SequenceEqual(nums));
    }
}
