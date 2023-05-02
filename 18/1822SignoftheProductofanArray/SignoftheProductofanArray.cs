namespace LeetCodeTasks._1822SignoftheProductofanArray
{
    public class SignoftheProductofanArray
    {
        public int ArraySign(int[] nums)
        {
            var result = 1;
            foreach (var num in nums)
            {
                if (num == 0) return 0;
                if (num < 0) result = -result;
            }

            return result;
        }
    }
}
