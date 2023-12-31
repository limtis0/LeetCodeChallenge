namespace LeetCodeChallenge;

[TestClass]
public class TestConvertInto2DArray
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        int[] nums = new int[] { 1, 3, 4, 1, 2, 3, 1 };

        List<List<int>> expected = new()
        {
            new() { 1, 3, 4, 2 },
            new() { 1, 3 },
            new() { 1 }
        };

        // Act
        var actual = ConvertInto2DArray.FindMatrix(nums);

        // Assert
        foreach (var (e, a) in expected.Zip(actual))
        {
            CollectionAssert.AreEquivalent(e, a.ToList());   
        }
    }
}
