namespace LeetCodeTasks._207CourseSchedule
{
    public class CourseSchedule
    {
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
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

            return parents.Count == 0;
        }
    }
}
