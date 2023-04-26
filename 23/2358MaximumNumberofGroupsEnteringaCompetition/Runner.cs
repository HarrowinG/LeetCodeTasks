using System;

namespace LeetCodeTasks._2358MaximumNumberofGroupsEnteringaCompetition
{
    public class Runner
    {
        public void Run()
        {
            //var grades = new[] { 10, 6, 12, 7, 3, 5 }; //3
            var grades = new[] { 8, 8 }; //1
            var cl = new MaximumNumberofGroupsEnteringaCompetition();
            var result = cl.MaximumGroups(grades);
            Console.WriteLine(result);
        }
    }
}
