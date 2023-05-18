namespace LeetCodeTasks._1557MinimumNumberofVerticestoReachAllNodes
{
    public class MinimumNumberofVerticestoReachAllNodes
    {
        public IList<int> FindSmallestSetOfVertices(int n, IList<IList<int>> edges)
        {
            var result = new List<int>();
            var set = new HashSet<int>();
            foreach (var edge in edges)
                set.Add(edge[1]);

            for (var i = 0; i < n; i++)
                if (!set.Contains(i)) result.Add(i);

            return result;
        }
    }
}
