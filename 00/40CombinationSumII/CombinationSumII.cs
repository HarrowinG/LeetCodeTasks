namespace LeetCodeTasks._40CombinationSumII
{
    public class CombinationSumII
    {
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            var result = new List<IList<int>>();
            Array.Sort(candidates);
            Dfs(candidates, 0, target, new List<int>(), result);
            return result;
        }

        private void Dfs(int[] candidates, int start, int target, IList<int> current, IList<IList<int>> result)
        {
            if (target == 0)
            {
                result.Add(current.ToList());
                return;
            }
            if (target < 0) return;

            for (int i = start; i < candidates.Length; i++)
            {
                if (i > start && candidates[i] == candidates[i - 1]) continue;

                current.Add(candidates[i]);
                Dfs(candidates, i + 1, target - candidates[i], current, result);
                current.RemoveAt(current.Count - 1);
            }
        }
    }
}
