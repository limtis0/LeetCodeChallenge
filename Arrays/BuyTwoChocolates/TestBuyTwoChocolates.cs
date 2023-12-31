namespace LeetCodeChallenge;

[TestClass]
public class TestBuyTwoChocolates
{
    [TestMethod]
    [DataRow(new int[] { 1, 2, 2 }, 3, 0)]
    [DataRow(new int[] { 3, 2, 3 }, 3, 3)]
    public void Test1(int[] prices, int money, int expected)
    {
        // Act
        int actual = BuyTwoChocolates.BuyChoco(prices, money);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
