using LeetCodeTasks.Utility;

namespace LeetCodeTasks._853CarFleet
{
    public class Runner
    {
        public void Run()
        {
            var target = 12; var strPosition = "[10,8,0,5,3]"; var strSpeed = "[2,4,1,1,3]";//3
            //var target = 10; var strPosition = "[3]"; var strSpeed = "[3]";//1
            //var target = 100; var strPosition = "[0,2,4]"; var strSpeed = "[4,2,1]";//1
            var position = InputUtility.StringToIntArray(strPosition);
            var speed = InputUtility.StringToIntArray(strSpeed);
            var cl = new CarFleetClass();
            var result = cl.CarFleet(target, position, speed);
            Console.WriteLine(result);
        }
    }
}
