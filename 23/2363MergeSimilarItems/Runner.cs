namespace LeetCodeTasks._2363MergeSimilarItems
{
    public class Runner
    {
        public void Run()
        {
            /*
            var items1 = new int[][]
            {
                new int[] { 1, 1 },
                new int[] { 4, 5 },
                new int[] { 3, 8 },
            };
            var items2 = new int[][]
            {
                new int[]{ 3, 1 },
                new int[]{ 1, 5 },
            };//[[1,6],[3,9],[4,5]]
            */
            /*
            var items1 = new int[][]
            {
                new int[] { 1, 1 },
                new int[] { 3, 2 },
                new int[] { 2, 3 },
            };
            var items2 = new int[][]
            {
                new int[]{ 2, 1 },
                new int[]{ 3, 2 },
                new int[]{ 1, 3 },
            };//[[1,4],[2,4],[3,4]]
            */
            
            var items1 = new int[][]
            {
                new int[] { 1, 3 },
                new int[] { 2, 2 },
            };
            var items2 = new int[][]
            {
                new int[]{ 7, 1 },
                new int[]{ 2, 2 },
                new int[]{ 1, 4 },
            };//[[1,7],[2,4],[7,1]]
            
            var cl = new MergeSimilarItemsClass();
            var listListResult = cl.MergeSimilarItems(items1, items2);
            var str = "[";
            foreach (var item in listListResult)
            {
                str += $"[{item[0]}, {item[1]}],";
            }
            str = str.TrimEnd(',');
            str += "]";
            Console.WriteLine(str);
        }
    }
}
