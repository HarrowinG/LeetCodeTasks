using LeetCodeTasks.Utility;

namespace LeetCodeTasks._155MinStack
{
    public class Runner
    {
        public void Run()
        {
            var cl = new MinStack();
            var result = new List<int>();
            cl.Push(-2);
            cl.Push(0);
            cl.Push(-3);
            result.Add(cl.GetMin()); // return -3
            cl.Pop();
            result.Add(cl.Top());    // return 0
            result.Add(cl.GetMin()); // return -2
            Console.WriteLine(ResultUtility.List(result));
        }
    }
}
