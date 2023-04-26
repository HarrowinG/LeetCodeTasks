namespace LeetCodeTasks.Utility
{
    public static class LinkedListUtility
    {
        public static ListNode BuildList(int[] nums)
        {
            var head = new ListNode(0);
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                var node = new ListNode(nums[i]);
                node.next = head.next;
                head.next = node;
            }

            return head.next;
        }
    }
}
