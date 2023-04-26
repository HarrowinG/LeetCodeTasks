using LeetCodeTasks.Utility;

namespace LeetCodeTasks._21MergeTwoSortedLists
{
    public class MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            var result = new ListNode(0);
            var pointer = result;
            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    pointer.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    pointer.next = list2;
                    list2 = list2.next;
                }

                pointer = pointer.next;
            }

            if (list1 != null)
            {
                pointer.next = list1;
            }
            else
            {
                pointer.next = list2;
            }

            return result.next;
        }
    }
}
