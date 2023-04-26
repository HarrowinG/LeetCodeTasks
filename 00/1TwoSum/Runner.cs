namespace LeetCodeTasks._1TwoSum
{
    public class Runner
    {
        public void Run()
        {
            var nums = new int[] { 2, 7, 11, 15 }; var target = 9;//[0,1]
            //var nums = new int[] { 3, 2, 4 }; var target = 6;//[1,2]
            //var nums = new int[] { 3, 3 }; var target = 6;//[0,1]
            var cl = new TwoSumClass();
            var result = cl.TwoSum(nums, target);
            Console.Write($"[{result[0]},{result[1]}]");
        }
    }
}
