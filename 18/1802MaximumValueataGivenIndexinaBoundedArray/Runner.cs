namespace LeetCodeTasks._1802MaximumValueataGivenIndexinaBoundedArray
{
    public class Runner
    {
        public void Run()
        {
            var cl = new MaximumValueataGivenIndexinaBoundedArray();
            //int n = 4, index = 2, maxSum = 6;//2
            int n = 6, index = 1, maxSum = 10;//3
            var result = cl.MaxValue(n, index, maxSum);
            Console.WriteLine(result);
        }
    }
}
