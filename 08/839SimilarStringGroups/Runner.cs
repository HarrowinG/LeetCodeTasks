namespace LeetCodeTasks._839SimilarStringGroups
{
    public class Runner
    {
        public void Run()
        {
            var cl = new SimilarStringGroups();
            //var strs = new string[] { "tars", "rats", "arts", "star" };//2
            var strs = new string[] { "omv", "ovm" };//1
            var result = cl.NumSimilarGroups(strs);
            Console.WriteLine(result);
        }
    }
}
