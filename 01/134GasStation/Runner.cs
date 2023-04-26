using LeetCodeTasks.Utility;

namespace LeetCodeTasks._134GasStation
{
    public class Runner
    {
        public void Run()
        {
            var gasNums = "[1,2,3,4,5]"; var costNums = "[3,4,5,1,2]";//3
            //var gasNums = "[2,3,4]"; var cosNums = "[3,4,3]";//-1
            var gas = InputUtility.StringToIntArray(gasNums);
            var cost = InputUtility.StringToIntArray(costNums);
            var cl = new GasStation();
            var result = cl.CanCompleteCircuit(gas, cost);
            Console.WriteLine(result);
        }
    }
}
