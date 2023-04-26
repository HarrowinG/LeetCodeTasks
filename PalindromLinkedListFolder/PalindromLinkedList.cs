using LeetCodeTasks.Utility;

namespace LeetCodeTasks.PalindromLinkedListFolder
{
    public class PalindromLinkedList
    {
        public bool IsPalindrome(ListNode head)
        {
            if (head.next == null)
            {
                return true;
            }

            var tail = head;
            var mid = head;
            while (tail.next?.next != null)
            {
                mid = mid.next;
                tail = tail.next.next;
            }
            mid = mid.next;

            var reverseHead = BuildHalfReverse(mid);

            while (reverseHead != null)
            {
                if (reverseHead.val != head.val)
                {
                    return false;
                }

                reverseHead = reverseHead.next;
                head = head.next;
            }

            return true;
        }

        private ListNode BuildHalfReverse(ListNode current)
        {
            var head = current;
            if (current.next != null)
            {
                head = current.next;
                current.next = head.next;
                head.next = current;
            }

            while (current.next != null)
            {
                var rest = current.next.next;
                current.next.next = head;
                head = current.next;
                current.next = rest;
            }

            return head;
        }
    }
}
