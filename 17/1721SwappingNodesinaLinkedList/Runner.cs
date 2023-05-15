using LeetCodeTasks.Utility;

namespace LeetCodeTasks._1721SwappingNodesinaLinkedList
{
    public class Runner
    {
        public void Run()
        {
            var cl = new SwappingNodesinaLinkedList();
            //var strHead = "[1,2,3,4,5]"; var k = 2;//[1,4,3,2,5]
            var strHead = "[7,9,6,6,7,8,3,0,9,5]"; var k = 5;//[7,9,6,6,8,7,3,0,9,5]
            var head = LinkedListUtility.BuildList(InputUtility.StringToIntArray(strHead));
            var result = cl.SwapNodes(head, k);
            Console.WriteLine(ResultUtility.LinkedList(result));
        }
    }
}
