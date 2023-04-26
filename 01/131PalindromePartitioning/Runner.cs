using LeetCodeTasks.Utility;

namespace LeetCodeTasks._131PalindromePartitioning
{
    public class Runner
    {
        public void Run()
        {
            //var s = "aab";//[["a","a","b"],["aa","b"]]
            //var s = "a";//[["a"]]
            var s = "efe";//[["efe"],["e","f","e"]]
            var cl = new PalindromePartitioning();
            var result = cl.Partition(s);
            Console.WriteLine(ResultUtility.List2D(result));
        }
    }
}
