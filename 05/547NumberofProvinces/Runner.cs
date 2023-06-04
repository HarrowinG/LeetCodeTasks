using LeetCodeTasks.Utility;

namespace LeetCodeTasks._547NumberofProvinces
{
    public class Runner
    {
        public void Run()
        {
            var cl = new NumberofProvinces();
            //var strIsConnected = "[[1,1,0],[1,1,0],[0,0,1]]";//2
            var strIsConnected = "[[1,0,0],[0,1,0],[0,0,1]]";//3
            var isConnected = InputUtility.StringToIntArray2D(strIsConnected);
            var result = cl.FindCircleNum(isConnected);
            Console.WriteLine(result);
        }
    }
}
