using LeetCodeTasks.Utility;

namespace LeetCodeTasks._1406StoneGameIII
{
    public class Runner
    {
        public void Run()
        {
            var cl = new StoneGameIIIClass();
            var strValues = "[1,2,3,7]";//Bob
            //var strValues = "[1,2,3,-9]";//Alice
            //var strValues = "[1,2,3,6]";//Tie
            var values = InputUtility.StringToIntArray(strValues);
            var result = cl.StoneGameIII(values);
            Console.WriteLine(result);
        }
    }
}
