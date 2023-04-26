using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2433FindTheOriginalArrayofPrefixXor
{
    public class Runner
    {
        public void Run()
        {
            //var strPref = "[5,2,0,3,1]";//[5,7,2,3,2]
            var strPref = "[13]";//[13]
            var pref = InputUtility.StringToIntArray(strPref);
            var cl = new FindTheOriginalArrayofPrefixXor();
            var result = cl.FindArray(pref);
            Console.WriteLine(ResultUtility.Array(result));
        }
    }
}
