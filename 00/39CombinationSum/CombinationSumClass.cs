namespace LeetCodeTasks._39CombinationSum
{
    public class CombinationSumClass
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            var result = new List<IList<int>>();
            var current = new List<int>();
            Dfs(candidates, target, 0, current, result, 0);

            return result;
        }

        private void Dfs(int[] candidates, int target, int i, List<int> current, List<IList<int>> result, int sum)
        {
            if (sum == target)
            {
                result.Add(new List<int>(current));
                return;
            }

            if (i == candidates.Length || sum > target) return;

            current.Add(candidates[i]);
            Dfs(candidates, target, i, current, result, sum + candidates[i]);
            current.RemoveAt(current.Count - 1);

            Dfs(candidates, target, i + 1, current, result, sum);
        }
    }
}
