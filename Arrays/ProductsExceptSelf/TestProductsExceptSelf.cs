namespace LeetCodeChallenge;

[TestClass]
public class TestProductsExceptSelf
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        int[] nums = { 1, 2, 3, 4 };
        int[] expected = { 24, 12, 8, 6 };

        // Act
        int[] actual = ProductsExceptSelf.Product(nums);

        // Assert
        Assert.IsTrue(expected.SequenceEqual(actual));
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        int[] nums = { -1, 1, 0, -3, 3 };
        int[] expected = { 0, 0, 9, 0, 0 };

        // Act
        int[] actual = ProductsExceptSelf.Product(nums);

        // Assert
        Assert.IsTrue(expected.SequenceEqual(actual));
    }

    [TestMethod]
    public void Test3()
    {
        // Arrange
        int[] nums = { 0, 1, -1, -3, 3 };
        int[] expected = { 9, 0, 0, 0, 0 };

        // Act
        int[] actual = ProductsExceptSelf.Product(nums);

        // Assert
        Assert.IsTrue(expected.SequenceEqual(actual));
    }

    [TestMethod]
    public void Test4()
    {
        // Arrange
        int[] nums = { 3, 1, -1, -3, 0 };
        int[] expected = { 0, 0, 0, 0, 9 };

        // Act
        int[] actual = ProductsExceptSelf.Product(nums);

        // Assert
        Assert.IsTrue(expected.SequenceEqual(actual));
    }
}
