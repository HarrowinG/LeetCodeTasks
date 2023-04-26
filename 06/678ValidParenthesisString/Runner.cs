namespace LeetCodeTasks._678ValidParenthesisString
{
    public class Runner
    {
        public void Run()
        {
            var s = "()";//true
            //var s = "(*)";//true
            //var s = "(*))";//true
            var cl = new ValidParenthesisString();
            var result = cl.CheckValidString(s);
            Console.WriteLine(result);
        }
    }
}
