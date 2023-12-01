namespace SinglyLinkedList;

public class ListNode
{
    public int val;
    public ListNode? next;

    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }

    // Initialize LinkedList with an int[]
    public ListNode(int[] values) : this()
    {
        if (values == null || values.Length == 0)
        {
            return;
        }

        val = values[0];
        ListNode current = this;

        for (int i = 1; i < values.Length; i++)
        {
            current.next = new ListNode(values[i]);
            current = current.next;
        }
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        ListNode? that = this;
        ListNode? other = (ListNode)obj;

        while (that != null && other != null)
        {
            if (that.val != other.val)
            {
                return false;
            }

            that = that.next;
            other = other.next;
        }

        // If one of them is not null, they have different lengths
        return that == null && other == null;
    }

    public override int GetHashCode()
    {
        return val.GetHashCode();
    }
}
