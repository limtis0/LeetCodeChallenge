using BinaryTree;

namespace LeetCodeChallenge;

[TestClass]
public class TestInorderTraversal
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        var treeValues = new int?[] { 1, null, 2, 3 };
        TreeNode tree = new(treeValues);

        List<int> expected = new() { 1, 3, 2 };

        // Act
        var actual = InorderTraversal.Solution(tree);

        // Assert
        Assert.IsTrue(expected.SequenceEqual(actual));
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        var treeValues = new int?[] { 1 };
        TreeNode tree = new(treeValues);

        List<int> expected = new() { 1 };

        // Act
        var actual = InorderTraversal.Solution(tree);

        // Assert
        Assert.IsTrue(expected.SequenceEqual(actual));
    }

    [TestMethod]
    public void Test3()
    {
        // Arrange
        var treeValues = new int?[] { 4, 2, 5, 1, 3 };
        TreeNode tree = new(treeValues);

        List<int> expected = new() { 1, 2, 3, 4, 5 };

        // Act
        var actual = InorderTraversal.Solution(tree);

        // Assert
        Assert.IsTrue(expected.SequenceEqual(actual));
    }
}
