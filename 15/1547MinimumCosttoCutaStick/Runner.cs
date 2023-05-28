using LeetCodeTasks.Utility;

namespace LeetCodeTasks._1547MinimumCosttoCutaStick
{
    public class Runner
    {
        public void Run()
        {
            var cl = new MinimumCosttoCutaStick();
            //var n = 7; var strCuts = "[1,3,4,5]";//16
            var n = 9; var strCuts = "[5,6,1,4,2]";//22
            var cuts = InputUtility.StringToIntArray(strCuts);
            var result = cl.MinCost(n, cuts);
            Console.WriteLine(result);
        }
    }
}
