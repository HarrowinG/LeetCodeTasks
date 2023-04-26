namespace LeetCodeTasks._2373LargestLocalValuesinaMatrix
{
    public class Runner
    {
        public void Run()
        {
            var grid = new int[][]
            {
                new int[] { 9,9,8,1 },
                new int[] { 5,6,2,6 },
                new int[] { 8,2,6,4 },
                new int[] { 6,2,2,2 },
            };//[[9,9],[8,6]]
            /*
            var grid = new int[][]
            {
                new int[] { 1,1,1,1,1 },
                new int[] { 1,1,1,1,1 },
                new int[] { 1,1,2,1,1 },
                new int[] { 1,1,1,1,1 },
                new int[] { 1,1,1,1,1 },
            };//[[2,2,2],[2,2,2],[2,2,2]]
            */
            var cl = new LargestLocalValuesinaMatrix();
            var listListResult = cl.LargestLocal(grid);
            var str = "[";
            foreach (var listResult in listListResult)
            {
                str += "[";
                foreach(var item in listResult)
                {
                    str += $"{item},";
                }
                str = str.TrimEnd(',');
                str += "],";
            }
            str = str.TrimEnd(',');
            str += "]";
            Console.WriteLine(str);
        }
    }
}
