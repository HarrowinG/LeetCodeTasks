namespace LeetCodeTasks._3LongestSubstringWithoutRepeatingCharacters
{
    public class Runner
    {
        public void Run()
        {
            //var s = "abcabcbb";//3
            //var s = "bbbbb";//1
            //var s = "pwwkew";//3
            var s = "au";//2
            var cl = new LongestSubstringWithoutRepeatingCharacters();
            var result = cl.LengthOfLongestSubstring(s);
            Console.WriteLine(result);
        }
    }
}
