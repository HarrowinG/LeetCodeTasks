namespace LeetCodeTasks._66PlusOne
{
    public class Runner
    {
        public void Run()
        {
            //var digits = new int[] { 1, 2, 3 };//1,2,4
            //var digits = new int[] { 4, 3, 2, 1 };//4,3,2,2
            var digits = new int[] { 9 };//1,0
            var cl = new PlusOneClass();
            var listResults = cl.PlusOne(digits);
            var str = "[";
            foreach (var item in listResults)
            {
                str += $"{item},";
            }
            str = str.TrimEnd(',');
            str += "]";
            Console.WriteLine(str);
        }
    }
}
