namespace LeetCodeChallenge;

[TestClass]
public class TestNumberOfLaserBeams
{
    [TestMethod]
    [DataRow(8, "011001", "000000", "010100", "001000")]
    [DataRow(0, "000", "111", "000")]
    public void Tests(int expected, params string[] bank)
    {
        // Act
        int actual = NumberOfLaserBeams.NumberOfBeams(bank);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
