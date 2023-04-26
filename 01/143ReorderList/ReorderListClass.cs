using LeetCodeTasks.Utility;

namespace LeetCodeTasks._143ReorderList
{
    public class ReorderListClass
    {
        public void ReorderList(ListNode head)
        {
            var slow = head;
            var fast = head.next;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            var right = Reverse(slow.next);
            slow.next = null;
            var left = head;

            while (right != null)
            {
                var tmp1 = left.next;
                var tmp2 = right.next;
                left.next = right;
                right.next = tmp1;
                left = tmp1;
                right = tmp2;
            }
        }

        private ListNode Reverse(ListNode node)
        {
            if (node == null) return null;

            var newHead = node;
            if (node.next != null)
            {
                newHead = Reverse(node.next);
                node.next.next = node;
            }
            node.next = null;

            return newHead;
        }
    }
}
