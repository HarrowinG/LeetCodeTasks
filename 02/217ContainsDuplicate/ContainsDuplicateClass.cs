namespace LeetCodeTasks._217ContainsDuplicate
{
    public class ContainsDuplicateClass
    {
        public bool ContainsDuplicate(int[] nums)
        {
            return Set(nums);
            //return Sort(nums);
        }

        private bool Set(int[] nums)
        {
            var set = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (set.Contains(nums[i])) return true;
                set.Add(nums[i]);
            }

            return false;
        }

        private bool Sort(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1]) return true;
            }

            return false;
        }
    }
}
