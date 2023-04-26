using LeetCodeTasks.Utility;

namespace LeetCodeTasks._213HouseRobberII
{
    public class Runner
    {
        public void Run()
        {
            var strNums = "[2,3,2]";//3
            //var strNums = "[1,2,3,1]";//4
            //var strNums = "[1,2,3]";//3
            //var strNums = "[2,1,3,2,8]";//11
            //var strNums = "[1,2,1,1]";//3
            var nums = InputUtility.StringToIntArray(strNums);
            var cl = new HouseRobberII();
            var result = cl.Rob(nums);
            Console.WriteLine(result);
        }
    }
}
