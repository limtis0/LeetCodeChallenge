namespace LeetCodeChallenge;

[TestClass]
public class TestMaxNumberOfKSumPairs
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        int[] nums = new int[] {1,2,3,4};
        int k = 5;
        
        int expected = 2;

        // Act
        int actual = MaxNumberOfKSumPairs.MaxOperations(nums, k);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        int[] nums = new int[] {3,1,3,4,3};
        int k = 6;
        
        int expected = 1;

        // Act
        int actual = MaxNumberOfKSumPairs.MaxOperations(nums, k);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
