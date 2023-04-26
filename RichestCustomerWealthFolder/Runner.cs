using System;

namespace LeetCodeTasks.RichestCustomerWealthFolder
{
    public class Runner
    {
        public void Run()
        {
            var richestCustomerWealth = new RichestCustomerWealth();
            /*
            var mat = new[]
            {
                new [] {1, 2, 3},
                new [] {3, 2, 1}
            };
            
            var mat = new[]
            {
                new [] {1, 5},
                new [] {7, 3},
                new [] {3, 5}
            };
            */
            var mat = new[]
            {
                new [] {2, 8, 7},
                new [] {7, 1, 3},
                new [] {1, 9, 5}
            };
            
            var result = richestCustomerWealth.MaximumWealth(mat);
            Console.WriteLine(result);
        }
    }
}
