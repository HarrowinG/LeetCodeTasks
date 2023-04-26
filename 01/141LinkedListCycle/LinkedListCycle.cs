using LeetCodeTasks.Utility;

namespace LeetCodeTasks._141LinkedListCycle
{
    public class LinkedListCycle
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null) return false;

            var slow = head;
            var fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast) return true;
            }

            return false;
        }
    }
}
