using LeetCodeTasks.Utility;

namespace LeetCodeTasks._55JumpGame
{
    public class Runner
    {
        public void Run()
        {
            //var strNums = "[2,3,1,1,4]";//true
            //var strNums = "[3,2,1,0,4]";//false
            var strNums = "[4,2,0,0,1,1,4,4,4,0,4,0]";//true
            var nums = InputUtility.StringToIntArray(strNums);
            var cl = new JumpGame();
            var result = cl.CanJump(nums);
            Console.WriteLine(result);
        }
    }
}
