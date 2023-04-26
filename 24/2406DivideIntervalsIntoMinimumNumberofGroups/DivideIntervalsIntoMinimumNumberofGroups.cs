namespace LeetCodeTasks._2406DivideIntervalsIntoMinimumNumberofGroups
{
    public class DivideIntervalsIntoMinimumNumberofGroups
    {
        public int MinGroups(int[][] intervals)
        {
            Array.Sort(intervals, Comparer<int[]>.Create((a, b) => a[0].CompareTo(b[0])));
            var queue = new PriorityQueue<int, int>();
            foreach (var interval in intervals)
            {
                if (queue.Count != 0 && queue.Peek() < interval[0])
                {
                    queue.Dequeue();
                }

                queue.Enqueue(interval[1], interval[1]);
            }

            return queue.Count;
        }
    }
}
