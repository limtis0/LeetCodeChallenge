namespace LeetCodeChallenge.FindConsecFromDataStream;

[TestClass]
public class TestFindConsecFromDataStream
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        DataStream ds = new(4, 3);
        
        // Assert
        
        // <3 -> false
        Assert.IsFalse(ds.Consec(4));
        Assert.IsFalse(ds.Consec(4));

        // >= 3 -> true
        Assert.IsTrue(ds.Consec(4));
        Assert.IsTrue(ds.Consec(4));

        // Interruption -> false
        Assert.IsFalse(ds.Consec(3));

        // <3 -> false
        Assert.IsFalse(ds.Consec(4));
    }
}
