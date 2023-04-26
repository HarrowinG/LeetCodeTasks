using LeetCodeTasks.Utility;

namespace LeetCodeTasks._412FizzBuzz
{
    public class Runner
    {
        public void Run()
        {
            var cl = new FizzBuzzClass();
            //var n = 3;//["1","2","Fizz"]
            //var n = 5;//["1","2","Fizz","4","Buzz"]
            var n = 15;//["1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","FizzBuzz"]
            var result = cl.FizzBuzz(n);
            Console.WriteLine(ResultUtility.List(result));
        }
    }
}
