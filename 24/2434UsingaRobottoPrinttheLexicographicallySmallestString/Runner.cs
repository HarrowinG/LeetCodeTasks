namespace LeetCodeTasks._2434UsingaRobottoPrinttheLexicographicallySmallestString
{
    public class Runner
    {
        public void Run()
        {
            //var s = "zza";//azz
            //var s = "bac";//abc
            var s = "bdda";//addb
            var cl = new UsingaRobottoPrinttheLexicographicallySmallestString();
            var result = cl.RobotWithString(s);
            Console.WriteLine(result);
        }
    }
}
