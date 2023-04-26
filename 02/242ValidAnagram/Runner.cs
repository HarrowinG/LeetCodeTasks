namespace LeetCodeTasks._242ValidAnagram
{
    public class Runner
    {
        public void Run()
        {
            var s = "anagram"; var t = "nagaram"; //true
            //var s = "rat"; var t = "car"; //false
            var cl = new ValidAnagram();
            var result = cl.IsAnagram(s, t);
            Console.WriteLine(result);
        }
    }
}
