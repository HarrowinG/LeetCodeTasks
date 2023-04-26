namespace LeetCodeTasks._567PermutationinString
{
    public class Runner
    {
        public void Run()
        {
            //var s1 = "ab"; var s2 = "eidbaooo";//true
            var s1 = "ab"; var s2 = "eidboaoo";//false
            var cl = new PermutationinString();
            var result = cl.CheckInclusion(s1, s2);
            Console.WriteLine(result);
        }
    }
}
