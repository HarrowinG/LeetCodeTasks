using LeetCodeTasks.Utility;

namespace LeetCodeTasks._946ValidateStackSequences
{
    public class Runner
    {
        public void Run()
        {
            var cl = new ValidateStackSequencesClass();
            var strPushed = "[1,2,3,4,5]"; var strPopped = "[4,5,3,2,1]";//true
            //var strPushed = "[1,2,3,4,5]"; var strPopped = "[4,3,5,1,2]";//false
            var pushed = InputUtility.StringToIntArray(strPushed);
            var popped = InputUtility.StringToIntArray(strPopped);
            var result = cl.ValidateStackSequences(pushed, popped);
            Console.WriteLine(result);
        }
    }
}
