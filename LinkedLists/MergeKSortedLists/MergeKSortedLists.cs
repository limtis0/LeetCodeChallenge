using SinglyLinkedList;

namespace LeetCodeChallenge;

#pragma warning disable CS8600, CS8601, CS8603 // Possible null reference assignment.

// 23. https://leetcode.com/problems/merge-k-sorted-lists/
public class MergeKSortedLists
{
    public static ListNode MergeKLists(ListNode[] lists)
    {
        List<int> values = new();

        // O(n)
        for (int i = 0; i < lists.Length; i++)
        {
            ListNode node = lists[i];

            while (node is not null)
            {
                values.Add(node.val);
                node = node.next;
            }
        }

        // O(n * log(n))
        values.Sort();

        ListNode head = new();
        ListNode current = head;

        // O(n)
        for (int i = 0; i < values.Count; i++)
        {
            current.next = new(values[i]);
            current = current.next;
        }

        return head.next;
    }

    public static ListNode MergeKListsPriorityQueue(ListNode[] lists)
    {
        PriorityQueue<ListNode, int> queue = new();
        
        // Fill up the priority queue
        for (int i = 0; i < lists.Length; i++)
        {
            ListNode node = lists[i];

            if (node is not null)
            {
                queue.Enqueue(node, node.val);
            }
        }

        ListNode head = new();
        ListNode current = head;

        while (queue.Count != 0)
        {
            ListNode node = queue.Dequeue();

            if (node.next is not null)
            {
                queue.Enqueue(node.next, node.next.val);
            }

            current.next = node;
            current = current.next;
        }

        return head.next;
    }


    public static ListNode MergeKListsVertical(ListNode[] lists)
    {
        ListNode head = new();
        ListNode current = head;

        if (lists.Length == 0 || lists.All(l => l is null))
        {
            return null;
        }

        int nullCount;
        int minValueIndex = -1;

        while (true)
        {
            nullCount = 0;

            int minValue = int.MaxValue;

            // Find the smallest value amongst all lists
            for (int i = 0; i < lists.Length; i++)
            {
                ListNode list = lists[i];

                if (list is null)
                {
                    nullCount++;
                    continue;
                }

                if (list.val < minValue)
                {
                    minValue = list.val;
                    minValueIndex = i;
                }
            }

            
            current.val = minValue;

            lists[minValueIndex] = lists[minValueIndex].next;

            if (lists[minValueIndex] is null && nullCount == lists.Length - 1)
            {
                break;
            }

            current.next = new();
            current = current.next;
        }

        return head;
    }
}

#pragma warning restore CS8600, CS8601, CS8603 // Possible null reference assignment.
