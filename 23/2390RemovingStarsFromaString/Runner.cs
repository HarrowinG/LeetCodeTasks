namespace LeetCodeTasks._2390RemovingStarsFromaString
{
    public class Runner
    {
        public void Run()
        {
            //var s = "leet**cod*e";//lecoe
            //var s = "erase*****";//
            var s = "abb*cdfg*****x*";//a
            var cl = new RemovingStarsFromaString();
            var result = cl.RemoveStars(s);
            Console.WriteLine(result);
        }
    }
}
