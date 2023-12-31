namespace LeetCodeChallenge;

[TestClass]
public class TestMaxScoreAfterApplyingK
{
    [TestMethod]
    [DataRow(new int[] { 10, 10, 10, 10, 10 }, 5, 50)]
    [DataRow(new int[] { 1, 10, 3, 3, 3 }, 3, 17)]
    [DataRow(
        new int[]
        {
            238838724,
            196963851,
            539418658,
            120132686,
            273213807,
            57187185,
            68854249,
            619718192
        },
        7,
        2254532183
    )]
    public void Tests(int[] nums, int k, long expected)
    {
        // Act
        long actual = MaxScoreAfterApplyingK.MaxKelements(nums, k);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
