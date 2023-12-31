namespace LeetCodeChallenge;

[TestClass]
public class TestPermutationSequence
{
    [TestMethod]
    [DataRow(3, 3, "213")]
    [DataRow(4, 9, "2314")]
    [DataRow(3, 1, "123")]
    [DataRow(3, 2, "132")]
    public void Test(int n, int k, string expected)
    {
        // Act
        string actual = PermutationSequence.GetPermutation(n, k);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
