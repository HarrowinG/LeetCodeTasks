namespace LeetCodeTasks._2380TimeNeededtoRearrangeaBinaryString
{
    public class Runner
    {
        public void Run()
        {
            var s = "0110101";//4
            //var s = "11100";//0
            var cl = new TimeNeededtoRearrangeaBinaryString();
            var result = cl.SecondsToRemoveOccurrences(s);
            Console.WriteLine(result);
        }
    }
}
