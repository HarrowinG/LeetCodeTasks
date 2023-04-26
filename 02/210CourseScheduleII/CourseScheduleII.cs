namespace LeetCodeTasks._210CourseScheduleII
{
    public class CourseScheduleII
    {
        public int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            var result = new List<int>();
            var graph = new Dictionary<int, HashSet<int>>();
            var parents = new Dictionary<int, int>();
            foreach (var course in prerequisites)
            {
                parents[course[0]] = parents.GetValueOrDefault(course[0], 0) + 1;
                graph[course[1]] = graph.GetValueOrDefault(course[1], new HashSet<int>());
                graph[course[1]].Add(course[0]);
            }

            var queue = new Queue<int>();
            for (int i = 0; i < numCourses; i++)
                if (!parents.ContainsKey(i)) queue.Enqueue(i);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                result.Add(node);
                if (!graph.ContainsKey(node)) continue;

                foreach (var next in graph[node])
                {
                    if (!parents.ContainsKey(next)) continue;

                    parents[next]--;
                    if (parents[next] <= 0)
                    {
                        queue.Enqueue(next);
                        parents.Remove(next);
                    }
                }
            }

            return parents.Count == 0 ? result.ToArray() : Array.Empty<int>();
        }
    }
}
