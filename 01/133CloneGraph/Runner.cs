using LeetCodeTasks.Utility;

namespace LeetCodeTasks._133CloneGraph
{
    public class Runner
    {
        public void Run()
        {
            var nums = "[[2,4],[1,3],[2,4],[1,3]]";
            //var nums = "[[]]";
            //var nums = "[]";
            var arr = InputUtility.StringToIntArray2D(nums);
            var dict = new Dictionary<int, Node>();
            for (int i = 0; i < arr.Length; i++)
            {
                dict[i + 1] = new Node(i + 1);
            }
            foreach (var item in dict)
            {
                var neighbours = arr[item.Key - 1];
                foreach (var neighbor in neighbours)
                {
                    item.Value.neighbors.Add(dict[neighbor]);
                }
            }

            var cl = new CloneGraphClass();
            var result = cl.CloneGraph(dict.GetValueOrDefault(1));
            Console.WriteLine();
        }
    }
}
