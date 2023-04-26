namespace LeetCodeTasks._167TwoSumIIInputArrayIsSorted
{
    public class TwoSumIIInputArrayIsSorted
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            var l = 0;
            var r = numbers.Length - 1;
            while (l < r)
            {
                var sum = numbers[l] + numbers[r];
                if (sum == target) return new[] { l + 1, r + 1 };
                else if (sum < target) l++;
                else r--;
            }

            return Array.Empty<int>();
        }
    }
}
