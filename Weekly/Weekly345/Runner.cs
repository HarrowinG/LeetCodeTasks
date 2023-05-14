using LeetCodeTasks.Utility;

namespace LeetCodeTasks.Weekly345
{
    public class Runner
    {
        public void Run()
        {
            /*
            var cl = new FindtheLosersoftheCircularGame();
            //var n = 5; var k = 2;//[4,5]
            //var n = 4; var k = 4;//[2,3,4]
            //var n = 2; var k = 1;//[]
            var n = 5; var k = 3;//[2,3]
            var result = cl.CircularGameLosers(n, k);
            Console.WriteLine(ResultUtility.Array(result));
            */

            var cl = new NeighboringBitwiseXOR();
            //var strDerived = "[1,1,0]";//true
            //var strDerived = "[1,1]";//true
            //var strDerived = "[1,0]";//false
            //var strDerived = "[0]";//true
            //var strDerived = "[0,0,1]";//false
            var strDerived = "[0,1,1]";//true
            var derived = InputUtility.StringToIntArray(strDerived);
            var result = cl.DoesValidArrayExist(derived);
            Console.WriteLine(result);
        }
    }
}
