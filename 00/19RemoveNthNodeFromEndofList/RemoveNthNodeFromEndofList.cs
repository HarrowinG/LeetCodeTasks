using LeetCodeTasks.Utility;

namespace LeetCodeTasks._19RemoveNthNodeFromEndofList
{
    public class RemoveNthNodeFromEndofList
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var dummy = new ListNode(0, head);
            var slow = dummy;
            var fast = head;
            while (fast != null && n > 0)
            {
                fast = fast.next;
                n--;
            }

            while (fast != null)
            {
                slow = slow.next;
                fast = fast.next;
            }

            slow.next = slow.next.next;
            return dummy.next;
        }
    }
}
