using LeetCodeTasks.Utility;

namespace LeetCodeTasks._15ThreeSum
{
    public class Runner
    {
        public void Run()
        {
            var nums = new int[] { -1, 0, 1, 2, -1, -4 };//[[-1,-1,2],[-1,0,1]]
            //var nums = new int[] { 0, 1, 1 };//[]
            //var nums = new int[] { 0, 0, 0 };//[[0,0,0]]
            var cl = new ThreeSumClass();
            var result = cl.ThreeSum(nums);
            Console.WriteLine(ResultUtility.List2D(result));
        }
    }
}
