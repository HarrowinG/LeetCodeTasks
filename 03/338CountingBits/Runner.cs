namespace LeetCodeTasks._338CountingBits
{
    public class Runner
    {
        public void Run()
        {
            //var n = 2;//011
            var n = 5;//011212
            var cl = new CountingBits();
            var resultList = cl.CountBits(n);
            var str = "[";
            foreach (var item in resultList)
            {
                str += $"{item},";
            }
            str = str.TrimEnd(',');
            str += "]";
            Console.WriteLine(str);
        }
    }
}
