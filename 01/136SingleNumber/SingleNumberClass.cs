namespace LeetCodeTasks._136SingleNumber
{
    public class SingleNumberClass
    {
        public int SingleNumber(int[] nums)
        {
            var res = 0;
            foreach (var num in nums)
                res ^= num;

            return res;
        }
    }
}
