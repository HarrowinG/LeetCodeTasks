namespace LeetCodeTasks._90SubsetsII
{
    public class SubsetsII
    {
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            var result = new List<IList<int>>();
            Array.Sort(nums);
            Dfs(nums, 0, new List<int>(), result);
            return result;
        }

        private void Dfs(int[] nums, int start, IList<int> current, IList<IList<int>> result)
        {
            result.Add(current.ToList());
            for (int i = start; i < nums.Length; i++)
            {
                if (i > start && nums[i] == nums[i - 1]) continue;

                current.Add(nums[i]);
                Dfs(nums, i + 1, current, result);
                current.RemoveAt(current.Count - 1);
            }
        }
    }
}
