using LeetCodeTasks.Utility;

namespace LeetCodeTasks._11ContainerWithMostWater
{
    public class Runner
    {
        public void Run()
        {
            var strHeight = "[1,8,6,2,5,4,8,3,7]";//49
            //var strHeight = "[1,1]";//1
            var height = InputUtility.StringToIntArray(strHeight);
            var cl = new ContainerWithMostWater();
            var result = cl.MaxArea(height);
            Console.WriteLine(result);
        }
    }
}
