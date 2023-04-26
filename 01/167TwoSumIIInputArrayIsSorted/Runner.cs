using LeetCodeTasks.Utility;

namespace LeetCodeTasks._167TwoSumIIInputArrayIsSorted
{
    public class Runner
    {
        public void Run()
        {
            //var numbers = new int[] { 2, 7, 11, 15 }; var target = 9;//[1,2]
            //var numbers = new int[] { 2, 3, 4 }; var target = 6;//[1,3]
            var numbers = new int[] { -1, 0 }; var target = -1;//[1,2]
            var cl = new TwoSumIIInputArrayIsSorted();
            var result = cl.TwoSum(numbers, target);
            Console.WriteLine(ResultUtility.Array(result));
        }
    }
}
