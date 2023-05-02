using LeetCodeTasks.Utility;

namespace LeetCodeTasks._1822SignoftheProductofanArray
{
    public class Runner
    {
        public void Run()
        {
            var cl = new SignoftheProductofanArray();
            //var strNums = "[-1,-2,-3,-4,3,2,1]";//1
            //var strNums = "[1,5,0,2,-3]";//0
            var strNums = "[-1,1,-1,1,-1]";//-1
            var nums = InputUtility.StringToIntArray(strNums);
            var result = cl.ArraySign(nums);
            Console.WriteLine(result);
        }
    }
}
