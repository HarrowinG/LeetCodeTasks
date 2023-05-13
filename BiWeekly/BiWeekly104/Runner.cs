using LeetCodeTasks.Utility;

namespace LeetCodeTasks.BiWeekly104
{
    public class Runner
    {
        public void Run()
        {
            /*
            var cl = new NumberofSeniorCitizens();
            var details = new string[] { "7868190130M7522", "5303914400F9211", "9273338290F4010" };//2
            var result = cl.CountSeniors(details);
            Console.WriteLine(result);
            */

            /*
            var cl = new SuminaMatrix();
            var strNums = "[[7,2,1],[6,4,2],[6,5,3],[3,2,1]]";//15
            //var strNums = "[[1]]";//1
            var nums = InputUtility.StringToIntArray2D(strNums);
            var result = cl.MatrixSum(nums);
            Console.WriteLine(result);
            */

            var cl = new MaximumOR();
            //var strNums = "[12,9]"; var k = 1;//30
            var strNums = "[8,1,2]"; var k = 2;//35
            var nums = InputUtility.StringToIntArray(strNums);
            var result = cl.MaximumOr(nums, k);
            Console.WriteLine(result);
        }
    }
}
