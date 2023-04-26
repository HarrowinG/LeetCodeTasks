using LeetCodeTasks.Utility;

namespace LeetCodeTasks._347TopKFrequentElements
{
    public class Runner
    {
        public void Run()
        {
            //var nums = new int[] { 1, 1, 1, 2, 2, 3 }; var k = 2;//[1,2]
            var nums = new int[] { 1 }; var k = 1;//[1]
            var cl = new TopKFrequentElements();
            var result = cl.TopKFrequent(nums, k);
            Console.WriteLine(ResultUtility.Array(result));
        }
    }
}
