namespace LeetCodeTasks._46Permutations
{
    public class Permutations
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            var result = new List<IList<int>>();
            var used = new bool[nums.Length];
            Dfs(nums, used, new List<int>(), result);
            return result;
        }

        private void Dfs(int[] nums, bool[] used, IList<int> current, IList<IList<int>> result)
        {
            if (current.Count == nums.Length)
            {
                result.Add(current.ToList());
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (used[i]) continue;

                used[i] = true;
                current.Add(nums[i]);
                Dfs(nums, used, current, result);
                current.RemoveAt(current.Count - 1);
                used[i] = false;
            }
        }
    }
}
