namespace LeetCodeTasks._150EvaluateReversePolishNotation
{
    public class Runner
    {
        public void Run()
        {
            //var tokens = new string[] { "2", "1", "+", "3", "*" };//9
            //var tokens = new string[] { "4", "13", "5", "/", "+" };//6
            var tokens = new string[] { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" };//22
            var cl = new EvaluateReversePolishNotation();
            var result = cl.EvalRPN(tokens);
            Console.WriteLine(result);
        }
    }
}
