namespace LeetCodeTasks._2440CreateComponentsWithSameValue
{
    public class CreateComponentsWithSameValue
    {
        public int ComponentValue(int[] nums, int[][] edges)
        {
            var max = int.MinValue;
            var min = int.MaxValue;
            var sum = 0;
            foreach (var num in nums)
            {
                max = Math.Max(max, num);
                min = Math.Min(min, num);
                sum += num;
            }

            var children = new int[nums.Length];
            var graph = new Dictionary<int, HashSet<int>>();
            foreach (var edge in edges)
            {
                var a = edge[0];
                var b = edge[1];
                children[a]++;
                children[b]++;
                graph[a] = graph.GetValueOrDefault(a, new HashSet<int>());
                graph[a].Add(b);
                graph[b] = graph.GetValueOrDefault(b, new HashSet<int>());
                graph[b].Add(a);
            }

            for (var candidate = min; candidate < sum; candidate++)
                if (sum % candidate == 0 && Bfs(nums, children, graph, candidate))
                    return sum / candidate - 1;

            return 0;
        }

        private bool Bfs(int[] numsInit, int[] degreeInit, Dictionary<int, HashSet<int>> graph, int target)
        {
            var nums = numsInit.ToArray();
            var children = degreeInit.ToArray();
            var queue = new Queue<int>();
            for (var i = 0; i < nums.Length; i++)
                if (children[i] == 1) queue.Enqueue(i);

            while (queue.Count > 0)
            {
                var item = queue.Dequeue();
                children[item] = 0;
                foreach (var next in graph[item])
                {
                    if (nums[item] != target) nums[next] += nums[item];
                    children[next]--;

                    if (children[next] == 0) return nums[next] == target;
                    if (children[next] == 1) queue.Enqueue(next);
                }
            }

            return false;
        }
    }
}
