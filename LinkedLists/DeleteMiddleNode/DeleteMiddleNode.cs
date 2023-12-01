using SinglyLinkedList;

namespace LeetCodeChallenge;

// 2095. https://leetcode.com/problems/delete-the-middle-node-of-a-linked-list/
public class DeleteMiddleNode
{
    public static ListNode DeleteMiddle(ListNode head)
    {
        ListNode preslow = head;
        ListNode slow = head;
        ListNode? fast = head.next;

        #pragma warning disable CS8603 // Possible null reference return.
        if (fast is null)
        {
            return null;
        }
        #pragma warning restore CS8603 // Possible null reference return.

        int index = 1;

        while (fast is not null)
        {
            fast = fast.next;
            index++;
            
            if (index % 2 == 0)
            {
                preslow = slow;
                slow = slow.next!;
            }
        }

        preslow.next = slow.next;

        return head;
    }
}