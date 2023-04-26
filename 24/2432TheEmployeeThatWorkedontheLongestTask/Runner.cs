using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2432TheEmployeeThatWorkedontheLongestTask
{
    public class Runner
    {
        public void Run()
        {
            //var n = 10; var strLogs = "[[0,3],[2,5],[0,9],[1,15]]";//1
            //var n = 26; var strLogs = "[[1,1],[3,7],[2,12],[7,17]]";//3
            //var n = 2; var strLogs = "[[0,10],[1,20]]";//0
            var n = 70; var strLogs = "[[36,3],[1,5],[12,8],[25,9],[53,11],[29,12],[52,14]]";//12
            var logs = InputUtility.StringToIntArray2D(strLogs);
            var cl = new TheEmployeeThatWorkedontheLongestTask();
            var result = cl.HardestWorker(n, logs);
            Console.WriteLine(result);
        }
    }
}
