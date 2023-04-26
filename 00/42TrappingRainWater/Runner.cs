using LeetCodeTasks.Utility;

namespace LeetCodeTasks._42TrappingRainWater
{
    public class Runner
    {
        public void Run()
        {
            var cl = new TrappingRainWater();
            //var strHeight = "[0,1,0,2,1,0,1,3,2,1,2,1]";//6
            //var strHeight = "[4,2,0,3,2,5]";//9
            var strHeight = "[6,4,2,0,3,2,0,3,1,4,5,3,2,7,5,3,0,1,2,1,3,4,6,8,1,3]";//83
            var height = InputUtility.StringToIntArray(strHeight);
            var result = cl.Trap(height);
            Console.WriteLine(result);
        }
    }
}
