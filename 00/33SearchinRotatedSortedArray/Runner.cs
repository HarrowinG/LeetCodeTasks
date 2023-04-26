using LeetCodeTasks.Utility;

namespace LeetCodeTasks._33SearchinRotatedSortedArray
{
    public class Runner
    {
        public void Run()
        {
            //var strNums = "[4,5,6,7,0,1,2]"; var target = 0;//4
            //var strNums = "[4,5,6,7,0,1,2]"; var target = 3;//-1
            //var strNums = "[1]"; var target = 0;//-1
            var strNums = "[5,1,3]"; var target = 5;//0
            var nums = InputUtility.StringToIntArray(strNums);
            var cl = new SearchinRotatedSortedArray();
            var result = cl.Search(nums, target);
            Console.WriteLine(result);
        }
    }
}
