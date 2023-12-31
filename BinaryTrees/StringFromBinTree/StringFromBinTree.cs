using System.Text;
using BinaryTree;

namespace LeetCodeChallenge;

// 606. https://leetcode.com/problems/construct-string-from-binary-tree/
public class StringFromBinTree
{
    public static string Tree2str(TreeNode root)
    {
        StringBuilder sb = new();
        BuildString(root, sb);

        return sb.ToString();
    }

    private static void BuildString(TreeNode node, StringBuilder sb)
    {
        sb.Append(node.val);
        
        if (node.left is not null)
        {
            sb.Append('(');
            BuildString(node.left, sb);
            sb.Append(')');
        }
        else if (node.right is not null)
        {
            sb.Append("()");
        }
        
        if (node.right is not null)
        {
            sb.Append('(');
            BuildString(node.right, sb);
            sb.Append(')');
        }
    }
}
