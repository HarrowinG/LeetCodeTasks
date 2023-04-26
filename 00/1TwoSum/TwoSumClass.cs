namespace LeetCodeTasks._1TwoSum
{
    public class TwoSumClass
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();
            dict[nums[0]] = 0;
            for (var i = 1; i < nums.Length; i++)
            {
                var delta = target - nums[i];
                if (dict.ContainsKey(delta)) return new int[] { dict[delta], i };
                dict[nums[i]] = i;
            }

            return new int[2];
        }
    }
}
