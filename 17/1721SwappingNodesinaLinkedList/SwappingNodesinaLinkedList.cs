using LeetCodeTasks.Utility;

namespace LeetCodeTasks._1721SwappingNodesinaLinkedList
{
    public class SwappingNodesinaLinkedList
    {
        public ListNode SwapNodes(ListNode head, int k)
        {
            var first = head;
            var second = head;
            for (var i = 1; i < k; i++)
                second = second.next;

            var toChange = second;
            while (second.next != null)
            {
                second = second.next;
                first = first.next;
            }

            (toChange.val, first.val) = (first.val, toChange.val);
            return head;
        }
    }
}
