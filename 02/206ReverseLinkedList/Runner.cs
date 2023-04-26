using LeetCodeTasks.Utility;

namespace LeetCodeTasks._206ReverseLinkedList
{
    public class Runner
    {
        public void Run()
        {
            var nums = new int[] { 1, 2, 3, 4, 5 };
            //var nums = new int[] { 1, 2 };
            //var nums = new int[] { };
            var head = LinkedListUtility.BuildList(nums);
            var cl = new ReverseLinkedList();
            var result = cl.ReverseList(head);
            var str = "";
            while (result != null)
            {
                str += result.val;
                result = result.next;
            }
            Console.WriteLine(str);
        }
    }
}
