namespace LeetCodeTasks._2392BuildaMatrixWithConditions
{
    public class BuildaMatrixWithConditions
    {
        public int[][] BuildMatrix(int k, int[][] rowConditions, int[][] colConditions)
        {
            var rIds = TopologicalSort(k, rowConditions);
            var cIds = TopologicalSort(k, colConditions);
            if (rIds.Length == 0 || cIds.Length == 0) return new int[0][];

            var result = new int[k][];
            for (var i = 0; i < k; i++)
                result[i] = new int[k];

            for (var i = 1; i <= k; i++)
            {
                result[rIds[i - 1]][cIds[i - 1]] = i;
            }

            return result;
        }

        private int[] TopologicalSort(int k, int[][] conditions)
        {
            var graph = new Dictionary<int, HashSet<int>>();
            var parents = new Dictionary<int, int>();
            for (var i = 1; i <= k; i++)
            {
                parents[i] = 0;
            }

            for (int i = 0; i < conditions.Length; i++)
            {
                var parent = conditions[i][0];
                var child = conditions[i][1];
                graph[parent] = graph.GetValueOrDefault(parent, new HashSet<int>());
                if (!graph[parent].Contains(child))
                {
                    parents[child]++;
                }
                graph[parent].Add(child);
            }

            var sorted = new List<int>();
            var queue = new Queue<int>();
            foreach (var item in parents)
            {
                if (item.Value == 0) queue.Enqueue(item.Key);
            }

            while (queue.Count > 0)
            {
                var item = queue.Dequeue();
                sorted.Add(item);
                if (!graph.ContainsKey(item)) continue;
                foreach (var child in graph[item])
                {
                    parents[child]--;
                    if (parents[child] == 0)
                    {
                        queue.Enqueue(child);
                    }
                }
            }

            if (sorted.Count != k) return new int[0];
            var ids = Enumerable.Range(0, k).ToList();
            ids.Sort((a, b) => sorted[a].CompareTo(sorted[b]));

            return ids.ToArray();
        }
    }
}
