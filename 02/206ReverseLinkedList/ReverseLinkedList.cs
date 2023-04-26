using LeetCodeTasks.Utility;

namespace LeetCodeTasks._206ReverseLinkedList
{
    public class ReverseLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            return Recursive(head);
            //return Iterative(head);
        }

        private ListNode Recursive(ListNode head)
        {
            if (head == null) return null;

            var newHead = head;
            if (head.next != null)
            {
                newHead = Recursive(head.next);
                head.next.next = head;
            }
            head.next = null;

            return newHead;
        }

        private ListNode Iterative(ListNode head)
        {
            ListNode prev = null;
            var cur = head;

            while (cur != null)
            {
                var temp = cur.next;
                cur.next = prev;
                prev = cur;
                cur = temp;
            }

            return prev;
        }
    }
}
