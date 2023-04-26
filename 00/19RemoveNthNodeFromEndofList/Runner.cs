using LeetCodeTasks.Utility;

namespace LeetCodeTasks._19RemoveNthNodeFromEndofList
{
    public class Runner
    {
        public void Run()
        {
            //var nums = "[1,2,3,4,5]"; var n = 2;//[1,2,3,5]
            //var nums = "[1]"; var n = 1;//[]
            var nums = "[1,2]"; var n = 1;//[1]
            var head = LinkedListUtility.BuildList(InputUtility.StringToIntArray(nums));
            var cl = new RemoveNthNodeFromEndofList();
            var result = cl.RemoveNthFromEnd(head, n);
            Console.WriteLine(ResultUtility.LinkedList(result));
        }
    }
}
