using LeetCodeTasks.Utility;

namespace LeetCodeTasks._1502CanMakeArithmeticProgressionFromSequence
{
    public class Runner
    {
        public void Run()
        {
            var cl = new CanMakeArithmeticProgressionFromSequence();
            //var strArr = "[3,5,1]";//true
            var strArr = "[1,2,4]";//false
            var arr = InputUtility.StringToIntArray(strArr);
            var result = cl.CanMakeArithmeticProgression(arr);
            Console.WriteLine(result);
        }
    }
}
