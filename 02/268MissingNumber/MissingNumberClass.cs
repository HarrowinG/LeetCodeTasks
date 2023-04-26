namespace LeetCodeTasks._268MissingNumber
{
    public class MissingNumberClass
    {
        public int MissingNumber(int[] nums)
        {
            return Sum(nums);
            //return Xor(nums);
        }

        public int Sum(int[] nums)
        {
            var res = nums.Length;
            for (var i = 0; i < nums.Length; i++)
            {
                res += i - nums[i];
            }

            return res;
        }

        public int Xor(int[] nums)
        {
            var res = nums.Length;
            for (var i = 0; i < nums.Length; i++)
            {
                res ^= i ^ nums[i];
            }

            return res;
        }
    }
}
