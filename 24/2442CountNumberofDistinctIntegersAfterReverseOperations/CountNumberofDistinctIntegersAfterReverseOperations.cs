namespace LeetCodeTasks._2442CountNumberofDistinctIntegersAfterReverseOperations
{
    public class CountNumberofDistinctIntegersAfterReverseOperations
    {
        public int CountDistinctIntegers(int[] nums)
        {
            var set = new HashSet<int>();
            foreach (var num in nums)
            {
                set.Add(num);
                set.Add(Reverse(num));
            }

            return set.Count;
        }

        private int Reverse(int n)
        {
            var result = 0;
            for (; n > 0; n /= 10)
                result = result * 10 + n % 10;
            return result;
        }
    }
}
