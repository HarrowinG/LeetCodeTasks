using LeetCodeTasks.Utility;

namespace LeetCodeTasks.PalindromLinkedListFolder
{
    public class Runner
    {
        public void Run()
        {

            var head = BuildList(1, 2, 3, 4, 5, 6, 5, 4, 3, 2, 1);
            var palindromLinkedList = new PalindromLinkedList();
            var result = palindromLinkedList.IsPalindrome(head);
            Console.WriteLine(result);
        }

        private ListNode BuildList(params int[] nodes)
        {
            var head = new ListNode(nodes[0]);
            var current = head;
            for (int i = 1; i < nodes.Length; i++)
            {
                var node = new ListNode(nodes[i]);
                current.next = node;
                current = current.next;
            }

            return head;
        }
    }
}
