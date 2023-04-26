using System;

namespace LeetCodeTasks._2357MakeArrayZerobySubtractingEqualAmounts
{
    public class Runner
    {
        public void Run()
        {
            //var nums = new[] { 1, 5, 0, 3, 5 }; //3
            //var nums = new[] { 6, 5, 0, 6, 5 }; //3
            var nums = new[] { 0 }; //0
            //var nums = new[] { 1 }; //1
            var cl = new MakeArrayZerobySubtractingEqualAmounts();
            var result = cl.MinimumOperations(nums);
            Console.WriteLine(result);
        }
    }
}
