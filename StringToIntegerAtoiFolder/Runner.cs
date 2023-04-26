using System;

namespace LeetCodeTasks.StringToIntegerAtoiFolder
{
    public class Runner
    {
        public void Run()
        {
            var stringToIntegerAtoi = new StringToIntegerAtoi();
            //var s = "42";
            //var s = "   -42";
            //var s = "4193 with words";
            //var s = int.MinValue + "9";
            //var s = "words and 987";
            //var s = "-+12";
            var s = "20000000000000000000";
            var result = stringToIntegerAtoi.MyAtoi(s);
            Console.WriteLine(result);
        }
    }
}
