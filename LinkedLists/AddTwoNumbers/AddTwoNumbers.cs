using SinglyLinkedList;

namespace LeetCodeChallenge;

// 2. https://leetcode.com/problems/add-two-numbers/
#pragma warning disable CS8600, CS8603 // Converting null literal or possible null value to non-nullable type.

public class AddTwoNumbers
{
    public static ListNode Solution(ListNode l1, ListNode l2)
    {
        int sum;
        int carry = 0;

        ListNode head = new();
        ListNode current = head;
        
        while (l1 is not null || l2 is not null || carry > 0)
        {
            sum = 0;

            if (l1 is not null)
            {
                sum += l1.val;
                l1 = l1.next;
            }

            if (l2 is not null)
            {
                sum += l2.val;
                l2 = l2.next;
            }

            sum += carry;
            carry = Math.DivRem(sum, 10, out sum);

            current.next = new(sum);
            current = current.next;
        }

        return head.next;
    }
}

#pragma warning restore CS8600, CS8603 // Converting null literal or possible null value to non-nullable type.
