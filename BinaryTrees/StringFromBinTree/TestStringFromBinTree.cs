using BinaryTree;

namespace LeetCodeChallenge;

[TestClass]
public class TestStringFromBinTree
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        var treeValues = new int?[] { 1, 2, 3, 4 };
        TreeNode tree = new(treeValues);

        string expected = "1(2(4))(3)";

        // Act
        string result = StringFromBinTree.Tree2str(tree);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        var treeValues = new int?[] { 1, 2, 3, null, 4 };
        TreeNode tree = new(treeValues);

        string expected = "1(2()(4))(3)";

        // Act
        string result = StringFromBinTree.Tree2str(tree);

        // Assert
        Assert.AreEqual(expected, result);
    }
}
