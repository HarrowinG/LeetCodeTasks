using LeetCodeTasks.Utility;

namespace LeetCodeTasks._876MiddleoftheLinkedList
{
    public class MiddleoftheLinkedList
    {
        public ListNode MiddleNode(ListNode head)
        {
            var slow = head;
            var fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            return slow;
        }
    }
}
