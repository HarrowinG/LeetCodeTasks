using LeetCodeTasks.Utility;

namespace LeetCodeTasks._22GenerateParentheses
{
    public class Runner
    {
        public void Run()
        {
            var n = 3;//["((()))","(()())","(())()","()(())","()()()"]
            //var n = 1;//["()"]
            var cl = new GenerateParentheses();
            var result = cl.GenerateParenthesis(n);
            Console.WriteLine(ResultUtility.List(result));
        }
    }
}
