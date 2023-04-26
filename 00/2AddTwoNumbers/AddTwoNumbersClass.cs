using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2AddTwoNumbers
{
    public class AddTwoNumbersClass
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            return Dfs(l1, l2, 0);
        }

        private ListNode Dfs(ListNode l1, ListNode l2, int carry)
        {
            if (l1 == null && l2 == null)
            {
                if (carry == 0) return null;
                else return new ListNode(1);
            }
            if (l1 == null) return Dfs2(l2, carry);
            else if (l2 == null) return Dfs2(l1, carry);

            var sum = l1.val + l2.val + carry;
            return new ListNode(sum % 10, Dfs(l1.next, l2.next, sum / 10));
        }

        private ListNode Dfs2(ListNode l, int carry)
        {
            if (l == null)
            {
                if (carry == 0) return null;
                else return new ListNode(1);
            }

            if (l.val == 9 && carry == 1)
            {
                return new ListNode(0, Dfs2(l.next, 1));
            }

            return new ListNode(l.val + carry, Dfs2(l.next, 0));
        }
    }
}
