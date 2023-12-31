namespace LeetCodeChallenge;

[TestClass]
public class TestNumberOfZeroFilledSubarrays
{
    [TestMethod]
    [DataRow(new int[] { 1, 3, 0, 0, 2, 0, 0, 4 }, 6)]
    [DataRow(new int[] { 0, 0, 0, 2, 0, 0 }, 9)]
    [DataRow(new int[] { 2, 10, 2019 }, 0)]
    public void Tests(int[] nums, long expected)
    {
        // Act
        long actual = NumberOfZeroFilledSubarrays.ZeroFilledSubarray(nums);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestBig()
    {
        // Arrange
        int[] nums = new int[100_000];
        long expected = 5_000_050_000;

        // Act
        long actual = NumberOfZeroFilledSubarrays.ZeroFilledSubarray(nums);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
