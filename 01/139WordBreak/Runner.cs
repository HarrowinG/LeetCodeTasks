namespace LeetCodeTasks._139WordBreak
{
    public class Runner
    {
        public void Run()
        {
            var s = "leetcode"; var wordDict = new List<string> { "leet", "code" };//true
            //var s = "applepenapple"; var wordDict = new List<string> { "apple", "pen" };//true
            //var s = "catsandog"; var wordDict = new List<string> { "cats", "dog", "sand", "and", "cat" };//false
            var cl = new WordBreakClass();
            var result = cl.WordBreak(s, wordDict);
            Console.WriteLine(result);
        }
    }
}
