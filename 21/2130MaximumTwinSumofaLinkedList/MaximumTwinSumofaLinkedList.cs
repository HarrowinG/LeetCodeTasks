using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2130MaximumTwinSumofaLinkedList
{
    public class MaximumTwinSumofaLinkedList
    {
        public int PairSum(ListNode head)
        {
            var result = 0;
            var slow = head;
            var fast = head;
            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }

            slow = Reverse(slow);

            while (slow != null)
            {
                result = Math.Max(result, slow.val + head.val);
                slow = slow.next;
                head = head.next;
            }

            return result;
        }

        private ListNode Reverse(ListNode current)
        {
            ListNode prev = null;
            while (current != null)
            {
                var next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }

            return prev;
        }
    }
}
