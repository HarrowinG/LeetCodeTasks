using LeetCodeTasks.Utility;

namespace LeetCodeTasks._399EvaluateDivision
{
    public class Runner
    {
        public void Run()
        {
            var cl = new EvaluateDivision();
            var equations = new List<IList<string>>
            {
                new List<string> { "a", "b" },
                new List<string> { "b", "c" },
            };
            var values = new double[] { 2.0, 3.0 };
            var queries = new List<IList<string>>
            {
                new List<string> { "a", "c" },
                new List<string> { "b", "a" },
                new List<string> { "a", "e" },
                new List<string> { "a", "a" },
                new List<string> { "x", "x" },
            };//[6.00000,0.50000,-1.00000,1.00000,-1.00000]
            /*
            var equations = new List<IList<string>>
            {
                new List<string> { "a", "b" },
                new List<string> { "b", "c" },
                new List<string> { "bc", "cd" },
            };
            var values = new double[] { 1.5, 2.5, 5.0 };
            var queries = new List<IList<string>>
            {
                new List<string> { "a", "c" },
                new List<string> { "c", "b" },
                new List<string> { "bc", "cd" },
                new List<string> { "cd", "bc" },
            };//[3.75000,0.40000,5.00000,0.20000]
            */
            /*
            var equations = new List<IList<string>>
            {
                new List<string> { "a", "b" },
            };
            var values = new double[] { 0.5 };
            var queries = new List<IList<string>>
            {
                new List<string> { "a", "b" },
                new List<string> { "b", "a" },
                new List<string> { "a", "c" },
                new List<string> { "x", "y" },
            };//[0.50000,2.00000,-1.00000,-1.00000]
            */
            var result = cl.CalcEquation(equations, values, queries);
            Console.WriteLine(ResultUtility.Array(result));
        }
    }
}
