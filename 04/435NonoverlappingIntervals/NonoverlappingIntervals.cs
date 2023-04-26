namespace LeetCodeTasks._435NonoverlappingIntervals
{
    public class NonoverlappingIntervals
    {
        public int EraseOverlapIntervals(int[][] intervals)
        {
            var result = 0;
            Array.Sort(intervals, Comparer<int[]>.Create((a, b) => a[0].CompareTo(b[0])));

            var end = intervals[0][1];
            for (var i = 1; i < intervals.Length; i++)
            {
                if (intervals[i][0] < end)
                {
                    end = Math.Min(end, intervals[i][1]);
                    result++;
                }
                else end = intervals[i][1];
            }

            return result;
        }
    }
}
