using LeetCodeTasks.Utility;

namespace LeetCodeTasks._739DailyTemperatures
{
    public class Runner
    {
        public void Run()
        {
            var strTemperatures = "[73,74,75,71,69,72,76,73]"; //[1,1,4,2,1,1,0,0]
            //var strTemperatures = "[30,40,50,60]"; //[1,1,1,0]
            //var strTemperatures = "[30,60,90]"; //[1,1,0]
            var temperatures = InputUtility.StringToIntArray(strTemperatures);
            var cl = new DailyTemperaturesClass();
            var result = cl.DailyTemperatures(temperatures);
            Console.WriteLine(ResultUtility.Array(result));
        }
    }
}
