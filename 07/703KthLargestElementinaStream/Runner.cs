namespace LeetCodeTasks._703KthLargestElementinaStream
{
    public class Runner
    {
        public void Run()
        {
            var nums = new int[] { 4, 5, 8, 2 }; var k = 3; var adds = new int[] { 3, 5, 10, 9, 4 };//4,5,5,8,8
            var cl = new KthLargest(k, nums);
            var listResult = new List<int>();
            foreach (var item in adds)
            {
                listResult.Add(cl.Add(item));
            }

            var str = "[";
            foreach (var item in listResult)
            {
                str += $"{item},";
            }
            str = str.TrimEnd(',');
            str += "]";
            Console.WriteLine(str);
        }
    }
}
