using LeetCodeTasks.Utility;

namespace LeetCodeTasks.Weekly317
{
    public class Runner
    {
        public void Run()
        {
            /*
            //var strNums = "[1,3,6,10,12,15]";//9
            var strNums = "[1,2,4,7,10]";//0
            var nums = InputUtility.StringToIntArray(strNums);
            var cl = new _6220AverageValueofEvenNumbersThatAreDivisiblebyThree();
            var result = cl.AverageValue(nums);
            Console.WriteLine(result);
            */

            /*
            //var creators = new string[] { "alice", "bob", "alice", "chris" }; var ids = new string[] { "one", "two", "three", "four" }; var strViews = "[5,10,5,4]";//[["alice","one"],["bob","two"]]
            var creators = new string[] { "alice", "alice", "alice" }; var ids = new string[] { "a", "b", "c" }; var strViews = "[1,2,2]";//[["alice","b"]]
            var views = InputUtility.StringToIntArray(strViews);
            var cl = new _6221MostPopularVideoCreator();
            var result = cl.MostPopularCreator(creators, ids, views);
            Console.WriteLine(ResultUtility.List2D(result));
            */

            //long n = 16; var target = 6;//4
            //long n = 467; var target = 6;//33
            //long n = 6068060761; var target = 3;//3931939239
            long n = 19; var target = 1;//81
            var cl = new _6222MinimumAdditiontoMakeIntegerBeautiful();
            var result = cl.MakeIntegerBeautiful(n, target);
            Console.WriteLine(result);
        }
    }
}
