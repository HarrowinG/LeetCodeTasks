using LeetCodeTasks.Utility;

namespace LeetCodeTasks._143ReorderList
{
    public class Runner
    {
        public void Run()
        {
            //var nums = "[1,2,3,4]";//[1,4,2,3]
            //var nums = "[1,2,3,4,5]";//[1,5,2,4,3]
            var nums = "[1]";//[1]
            //var nums = "[1,2]";//[1,2]
            var head = LinkedListUtility.BuildList(InputUtility.StringToIntArray(nums));
            var cl = new ReorderListClass();
            cl.ReorderList(head);
            Console.WriteLine(ResultUtility.LinkedList(head));
        }
    }
}
