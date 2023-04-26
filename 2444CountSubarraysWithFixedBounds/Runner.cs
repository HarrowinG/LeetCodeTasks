using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2444CountSubarraysWithFixedBounds
{
    public class Runner
    {
        public void Run()
        {
            var strNums = "[1,3,5,2,7,5]"; var minK = 1; var maxK = 5;//2
            //var strNums = "[3,1,5,2,5,4]"; var minK = 1; var maxK = 5;//8
            //var strNums = "[1,1,1,1]"; var minK = 1; var maxK = 1;//10
            //var strNums = "[934372,927845,479424,49441,17167,17167,65553,927845,17167,927845,17167,425106,17167,927845,17167,927845,251338,17167]"; var minK = 17167; var maxK = 927845;//118
            var nums = InputUtility.StringToIntArray(strNums);
            var cl = new CountSubarraysWithFixedBounds();
            var result = cl.CountSubarrays(nums, minK, maxK);
            Console.WriteLine(result);
        }
    }
}
