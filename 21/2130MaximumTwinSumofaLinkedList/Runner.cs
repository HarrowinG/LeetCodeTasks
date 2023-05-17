using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2130MaximumTwinSumofaLinkedList
{
    public class Runner
    {
        public void Run()
        {
            var cl = new MaximumTwinSumofaLinkedList();
            //var strHead = "[5,4,2,1]";//6
            //var strHead = "[4,2,2,3]";//7
            var strHead = "[1,100000]";//100001
            var head = LinkedListUtility.BuildList(InputUtility.StringToIntArray(strHead));
            var result = cl.PairSum(head);
            Console.WriteLine(result);
        }
    }
}
