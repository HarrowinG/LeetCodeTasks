namespace LeetCodeTasks._14LongestCommonPrefix
{
    public class Runner
    {
        public void Run()
        {
            var cl = new LongestCommonPrefixClass();
            var strs = new[] {"flower", "flow", "flight"}; //"fl"
            //var strs = new[] { "dog", "racecar", "car" }; //""
            //var strs = new[] { "flower", "flower", "flower" }; //"flower"
            //var strs = new[] { "ab", "a" }; //"a"
            var result = cl.LongestCommonPrefix(strs);
            Console.WriteLine(result);
        }
    }
}
