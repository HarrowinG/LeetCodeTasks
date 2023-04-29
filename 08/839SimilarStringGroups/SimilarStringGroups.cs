namespace LeetCodeTasks._839SimilarStringGroups
{
    public class SimilarStringGroups
    {
        public int NumSimilarGroups(string[] strs)
        {
            var groups = 0;
            var visited = new bool[strs.Length];
            for (int i = 0; i < strs.Length; i++)
            {
                if (visited[i]) continue;

                groups++;
                Dfs(i, strs, visited);
            }

            return groups;
        }

        private void Dfs(int i, string[] strs, bool[] visited)
        {
            visited[i] = true;
            for (int j = 0; j < strs.Length; j++)
            {
                if (visited[j]) continue;

                if (AreNeighbors(strs[i], strs[j]))
                    Dfs(j, strs, visited);
            }
        }

        private bool AreNeighbors(string first, string second)
        {
            var difference = 0;
            for (var i = 0; i < first.Length; i++)
                if (first[i] != second[i]) difference++;

            return difference == 0 || difference == 2;
        }
    }
}
