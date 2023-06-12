namespace LeetCodeTasks._228SummaryRanges
{
    public class SummaryRangesClass
    {
        public IList<string> SummaryRanges(int[] nums)
        {
            var result = new List<string>(); 
            if (nums.Length == 0) return result;

            int start = nums[0], end = nums[0];
            for (var i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1] + 1)
                {
                    AddRange(result, start, end);
                    start = nums[i];
                }

                end = nums[i];
            }

            AddRange(result, start, end);
            return result;
        }

        private void AddRange(IList<string> result, int start, int end)
        {
            if (start == end) result.Add(start.ToString());
            else result.Add($"{start}->{end}");
        }
    }
}
