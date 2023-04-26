using LeetCodeTasks.Utility;

namespace LeetCodeTasks._45JumpGameII
{
    public class Runner
    {
        public void Run()
        {
            var strNums = "[2,3,1,1,4]";//2
            //var strNums = "[2,3,0,1,4]";//2
            var nums = InputUtility.StringToIntArray(strNums);
            var cl = new JumpGameII();
            var result = cl.Jump(nums);
            Console.WriteLine(result);
        }
    }
}
