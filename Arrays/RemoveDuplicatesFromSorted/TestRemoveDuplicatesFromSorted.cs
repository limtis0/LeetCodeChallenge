namespace LeetCodeChallenge;

[TestClass]
public class TestRemoveDuplicatesFromSorted
{
    [TestMethod]
    [DataRow(new int[] { 1, 1, 2 }, new int[] { 1, 2 })]
    [DataRow(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, new int[] { 0, 1, 2, 3, 4 })]
    public void Tests(int[] nums, int[] expectedNums)
    {
        // Act
        int actual = RemoveDuplicatesFromSorted.RemoveDuplicates(nums);

        // Assert
        Assert.AreEqual(expectedNums.Length, actual);

        for (int i = 0; i < actual; i++)
        {
            Assert.AreEqual(nums[i], expectedNums[i]);
        }
    }
}
