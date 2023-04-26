namespace LeetCodeTasks._56MergeIntervals
{
    public class MergeIntervals
    {
        public int[][] Merge(int[][] intervals)
        {
            Array.Sort(intervals, Comparer<int[]>.Create((a, b) => a[0].CompareTo(b[0])));
            var result = new List<int[]> { intervals[0] };
            for (var i = 1; i < intervals.Length; i++)
            {
                var last = result.Last();
                if (last[1] < intervals[i][0]) result.Add(intervals[i]);
                else
                {
                    last[1] = Math.Max(last[1], intervals[i][1]);
                }
            }

            return result.ToArray();
        }
    }
}
