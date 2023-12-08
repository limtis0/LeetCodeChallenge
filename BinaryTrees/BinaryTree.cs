namespace BinaryTree;

public class TreeNode
{
    public int val;
    public TreeNode? left;
    public TreeNode? right;

    public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }

    // BSF-Initialization
    public TreeNode(int?[] values) : this()
    {
        if (values == null || values.Length == 0)
        {
            return;
        }

        Queue<TreeNode> queue = new();
        int index = 0;
        val = values[index++]!.Value;

        queue.Enqueue(this);

        while (queue.Count > 0)
        {
            TreeNode current = queue.Dequeue();

            if (index < values.Length)
            {
                int? leftValue = values[index++];
                if (leftValue.HasValue)
                {
                    current.left = new TreeNode(leftValue.Value);
                    queue.Enqueue(current.left);
                }
            }

            if (index < values.Length)
            {
                int? rightValue = values[index++];
                if (rightValue.HasValue)
                {
                    current.right = new TreeNode(rightValue.Value);
                    queue.Enqueue(current.right);
                }
            }
        }
    }

    public override bool Equals(object? obj)
    {
        if (this == obj)
        {
            return true;
        }

        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        TreeNode other = (TreeNode)obj;

        // Recursively check left and right subtrees
        return val == other.val && Equals(left, other.left) && Equals(right, other.right);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(val, left, right);
    }
}
