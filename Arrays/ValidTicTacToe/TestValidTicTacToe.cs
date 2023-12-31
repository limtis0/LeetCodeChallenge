namespace LeetCodeChallenge;

[TestClass]
public class TestValidTicTacToe
{
    [TestMethod]
    [DataRow(new string[] { "O  ", "   ", "   " }, false)]
    [DataRow(new string[] { "XOX", " X ", "   " }, false)]
    [DataRow(new string[] { "XOX", "O O", "XOX" }, true)]
    [DataRow(new string[] { "XXX", "OOO", "   " }, false)]
    [DataRow(new string[] { "   ", "   ", "   " }, true)]
    public void Tests(string[] board, bool expected)
    {
        // Act
        bool actual = ValidTicTacToe.IsValid(board);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
