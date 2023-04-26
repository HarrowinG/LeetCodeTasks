namespace LeetCodeTasks._2437NumberofValidClockTimes
{
    public class Runner
    {
        public void Run()
        {
            //var time = "?5:00";//2
            //var time = "0?:0?";//100
            var time = "??:??";//1440
            var cl = new NumberofValidClockTimes();
            var result = cl.CountTime(time);
            Console.WriteLine(result);
        }
    }
}
