namespace LeetCodeTasks._2421NumberofGoodPaths
{
    public class NumberofGoodPaths
    {
        public int NumberOfGoodPaths(int[] vals, int[][] edges)
        {
            var result = 0;
            var parents = new Dictionary<int, int>();
            var counts = new (int Value, int Count)[vals.Length];
            var paths = new (int Value, int Node1, int Node2)[edges.Length];
            for (var i = 0; i < edges.Length; i++)
            {
                counts[i] = (vals[i], 1);
                paths[i] = (Math.Max(vals[edges[i][0]], vals[edges[i][1]]), edges[i][0], edges[i][1]);
            }
            counts[vals.Length - 1] = (vals[vals.Length - 1], 1);
            Array.Sort(paths, Comparer<(int Value, int Node1, int Node2)>.Create((a, b) => a.Value.CompareTo(b.Value)));

            foreach (var path in paths)
            {
                var p1 = Find(path.Node1);
                var p2 = Find(path.Node2);
                var c1 = counts[p1].Value == path.Value ? counts[p1].Count : 0;
                var c2 = counts[p2].Value == path.Value ? counts[p2].Count : 0;
                result += c1 * c2;
                parents[p2] = p1;
                counts[p1].Value = path.Value;
                counts[p1].Count = c1 + c2;
            }

            return result + vals.Length;

            int Find(int x)
            {
                var y = parents.GetValueOrDefault(x, x);
                if (y != x)
                {
                    y = Find(y);
                    parents[x] = y;
                }
                    
                return y;
            }
        }
    }
}
