using System;

namespace LeetCodeTasks._377CombinationSumIV
{
    public class Runner
    {
        public void Run()
        {
            var nums = new int[] { 1, 2, 3 }; var target = 4;//7
            //var nums = new int[] { 9 }; var target = 3;//0
            var cl = new CombinationSumIV();
            var result = cl.CombinationSum4(nums, target);
            Console.WriteLine(result);
        }
    }
}
