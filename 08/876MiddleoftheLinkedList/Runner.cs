using LeetCodeTasks.Utility;

namespace LeetCodeTasks._876MiddleoftheLinkedList
{
    public class Runner
    {
        public void Run()
        {
            var cl = new MiddleoftheLinkedList();
            //var strHead = "[1,2,3,4,5]";//3
            var strHead = "[1,2,3,4,5,6]";//4
            var head = LinkedListUtility.BuildList(InputUtility.StringToIntArray(strHead));
            var result = cl.MiddleNode(head);
            Console.WriteLine(result.val);
        }
    }
}
