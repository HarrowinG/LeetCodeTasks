using System;

namespace LeetCodeTasks.RomanToIntsFolder
{
    public class Runner
    {
        public void Run()
        {
            var romanToInts = new RomanToInts();
            var result = romanToInts.RomanToInt("MCMXCIV");
            Console.WriteLine(result);
        }
    }
}
