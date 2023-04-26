namespace LeetCodeTasks._78Subsets
{
    public class SubsetsClass
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            var result = new List<IList<int>>();
            var current = new List<int>();
            Dfs(nums, 0, current, result);

            return result;
        }

        private void Dfs(int[] nums, int i, List<int> current, List<IList<int>> result)
        {
            if (i == nums.Length)
            {
                result.Add(new List<int>(current));
                return;
            }

            current.Add(nums[i]);
            Dfs(nums, i + 1, current, result);
            current.RemoveAt(current.Count - 1);
            Dfs(nums, i + 1, current, result);
        }
    }
}
