using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2439MinimizeMaximumofArray
{
    public class Runner
    {
        public void Run()
        {
            var strNums = "[3,7,1,6]";//5
            //var strNums = "[10,1]";//10
            var nums = InputUtility.StringToIntArray(strNums);
            var cl = new MinimizeMaximumofArray();
            var result = cl.MinimizeArrayValue(nums);
            Console.WriteLine(result);
        }
    }
}
