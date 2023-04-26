using LeetCodeTasks.Utility;

namespace LeetCodeTasks._198HouseRobber
{
    public class Runner
    {
        public void Run()
        {
            //var strNums = "[1,2,3,1]";//4
            var strNums = "[2,7,9,3,1]";//12
            var nums = InputUtility.StringToIntArray(strNums);
            var cl = new HouseRobber();
            var result = cl.Rob(nums);
            Console.WriteLine(result);
        }
    }
}
