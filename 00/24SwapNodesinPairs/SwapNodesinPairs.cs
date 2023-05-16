using LeetCodeTasks.Utility;

namespace LeetCodeTasks._24SwapNodesinPairs
{
    public class SwapNodesinPairs
    {
        public ListNode SwapPairs(ListNode head)
        {
            var dummy = new ListNode();
            dummy.next = head;

            var prev = dummy;
            var current = head;

            while (current != null && current.next != null)
            {
                prev.next = current.next;
                current.next = prev.next.next;
                prev.next.next = current;

                prev = current;
                current = current.next;
            }

            return dummy.next;
        }
    }
}
