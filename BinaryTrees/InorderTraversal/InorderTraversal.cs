using BinaryTree;

namespace LeetCodeChallenge;

// 94. https://leetcode.com/problems/binary-tree-inorder-traversal/
public class InorderTraversal
{
    public static IList<int> Solution(TreeNode root)
    {
        if (root is null)
        {
            return new List<int>();
        }
        
        return RecursiveTraversal(root).ToList();
    }

    private static IEnumerable<int> RecursiveTraversal(TreeNode node)
    {
        if (node.left is not null)
        {
            foreach (int i in RecursiveTraversal(node.left))
            {
                yield return i;
            }
        }

        yield return node.val;

        if (node.right is not null)
        {
            foreach (int i in RecursiveTraversal(node.right))
            {
                yield return i;
            }
        }
    }
}
