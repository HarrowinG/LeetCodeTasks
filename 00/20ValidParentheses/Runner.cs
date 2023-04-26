namespace LeetCodeTasks._20ValidParentheses
{
    public class Runner
    {
        public void Run()
        {
            var s = "()";//true
            //var s = "()[]{}";//true
            //var s = "(]";//false
            var cl = new ValidParentheses();
            var result = cl.IsValid(s);
            Console.WriteLine(result);
        }
    }
}
