using LeetCodeTasks.Utility;

namespace LeetCodeTasks.Weekly316
{
    public class Runner
    {
        public void Run()
        {
            /*
            //var event1 = new string[] { "01:15", "02:00" }; var event2 = new string[] { "02:00", "03:00" };//true
            //var event1 = new string[] { "01:00", "02:00" }; var event2 = new string[] { "01:20", "03:00" };//true
            var event1 = new string[] { "10:00", "11:00" }; var event2 = new string[] { "14:00", "15:00" };//false
            var cl = new _6214DetermineifwoEventsHaveConflict();
            var result = cl.HaveConflict(event1, event2);
            Console.WriteLine(result);
            */

            /*
            var strNums = "[9,3,1,2,6,3]"; var k = 3;//4
            //var strNums = "[9,9,1,2,9,9]"; var k = 3;//0
            //var strNums = "[4]"; var k = 7;//0
            var nums = InputUtility.StringToIntArray(strNums);
            var cl = new _6224NumberofSubarraysWithGCDEqualtoK();
            var result = cl.SubarrayGCD(nums, k);
            Console.WriteLine(result);
            */

            var strNums = "[1,3,5,2]"; var strCost = "[2,3,1,14]";//8
            //var strNums = "[2,2,2,2,2]"; var strCost = "[4,2,8,1,3]";//0
            var nums = InputUtility.StringToIntArray(strNums);
            var cost = InputUtility.StringToIntArray(strCost);
            var cl = new _6216MinimumCosttoMakeArrayEqual();
            var result = cl.MinCost(nums, cost);
            Console.WriteLine(result);
        }
    }
}
