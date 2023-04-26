namespace LeetCodeTasks._416PartitionEqualSubsetSum
{
    public class PartitionEqualSubsetSum
    {
        public bool CanPartition(int[] nums)
        {
            return TopDown(nums);
            //return BottomUp(nums); //slightly faster but ToList consumes more memory
        }

        private bool BottomUp(int[] nums)
        {
            var sum = nums.Sum();
            if (sum % 2 != 0) return false;
            var half = sum / 2;

            var set = new HashSet<int> { 0 };
            foreach (var num in nums)
            {
                foreach (var s in set.ToList())
                {
                    if (s + num == half) return true;
                    set.Add(s + num);
                }
            }

            return false;
        }

        private bool TopDown(int[] nums)
        {
            var sum = nums.Sum();
            if (sum % 2 != 0) return false;
            var half = sum / 2;

            return Dfs(nums, half, 0, new bool?[nums.Length, half + 1]);
        }

        private bool Dfs(int[] nums, int sum, int id, bool?[,] cache)
        {
            if (id == nums.Length || sum < 0) return false;
            if (sum - nums[id] == 0) return true;
            if (cache[id, sum] == null)
            {
                cache[id, sum] = Dfs(nums, sum - nums[id], id + 1, cache) || Dfs(nums, sum, id + 1, cache);
            }

            return cache[id, sum].Value;
        }
    }
}
