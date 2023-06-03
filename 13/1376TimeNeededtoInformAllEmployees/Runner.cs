using LeetCodeTasks.Utility;

namespace LeetCodeTasks._1376TimeNeededtoInformAllEmployees
{
    public class Runner
    {
        public void Run()
        {
            var cl = new TimeNeededtoInformAllEmployees();
            //var n = 1; var headID = 0; var strManager = "[-1]"; var strInformTime = "[0]";//0
            //var n = 6; var headID = 2; var strManager = "[2,2,-1,2,2,2]"; var strInformTime = "[0,0,1,0,0,0]";//1
            var n = 6; var headID = 2; var strManager = "[2,2,-1,2,2,2]"; var strInformTime = "[0,0,1,0,0,0]";//1
            var manager = InputUtility.StringToIntArray(strManager);
            var informTime = InputUtility.StringToIntArray(strInformTime);
            var result = cl.NumOfMinutes(n, headID, manager, informTime);
            Console.WriteLine(result);
        }
    }
}
