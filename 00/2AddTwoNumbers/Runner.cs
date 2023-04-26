using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2AddTwoNumbers
{
    public class Runner
    {
        public void Run()
        {
            //var l1str = "[2,4,3]"; var l2str = "[5,6,4]";//[7,0,8]
            //var l1str = "[0]"; var l2str = "[0]";//[0]
            var l1str = "[9,9,9,9,9,9,9]"; var l2str = "[9,9,9,9]";//[8,9,9,9,0,0,0,1]
            var l1 = LinkedListUtility.BuildList(InputUtility.StringToIntArray(l1str));
            var l2 = LinkedListUtility.BuildList(InputUtility.StringToIntArray(l2str));
            var cl = new AddTwoNumbersClass();
            var result = cl.AddTwoNumbers(l1, l2);
            Console.WriteLine(ResultUtility.LinkedList(result));
        }
    }
}
