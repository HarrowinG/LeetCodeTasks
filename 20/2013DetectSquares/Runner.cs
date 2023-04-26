namespace LeetCodeTasks._2013DetectSquares
{
    public class Runner
    {
        public void Run()
        {
            DetectSquares detectSquares = new DetectSquares();
            detectSquares.Add(new []{3, 10});
            detectSquares.Add(new[] { 11, 2});
            detectSquares.Add(new[] { 3, 2});
            Console.WriteLine(detectSquares.Count(new[] { 11, 10})); // return 1. You can choose:
                                                                     //   - The first, second, and third points
            Console.WriteLine(detectSquares.Count(new[] { 14, 8}));  // return 0. The query point cannot form a square with any points in the data structure.
            detectSquares.Add(new[] { 11, 2});    // Adding duplicate points is allowed.
            Console.WriteLine(detectSquares.Count(new[] { 11, 10})); // return 2. You can choose:
                                           //   - The first, second, and third points
                                           //   - The first, third, and fourth points
        }
    }
}
