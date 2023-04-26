using LeetCodeTasks.Utility;

namespace LeetCodeTasks._238ProductofArrayExceptSelf
{
    public class Runner
    {
        public void Run()
        {
            //var nums = new int[] { 1, 2, 3, 4 };//[24,12,8,6]
            var nums = new int[] { -1, 1, 0, -3, 3 };//[0,0,9,0,0]
            var cl = new ProductofArrayExceptSelf();
            var result = cl.ProductExceptSelf(nums);
            Console.WriteLine(ResultUtility.Array(result));
        }
    }
}
