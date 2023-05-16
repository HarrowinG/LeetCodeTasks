using LeetCodeTasks.Utility;

namespace LeetCodeTasks._24SwapNodesinPairs
{
    public class Runner
    {
        public void Run()
        {
            var cl = new SwapNodesinPairs();
            var strHead = "[1,2,3,4]";//[2,1,4,3]
            //var strHead = "[]";//[]
            //var strHead = "[1]";//[1]
            var head = LinkedListUtility.BuildList(InputUtility.StringToIntArray(strHead));
            var result = cl.SwapPairs(head);
            Console.WriteLine(ResultUtility.LinkedList(result));
        }
    }
}
