namespace LeetCodeTasks._2365TaskSchedulerII
{
    public class TaskSchedulerIIClass
    {
        public long TaskSchedulerII(int[] tasks, int space)
        {
            long days = 0;
            var dict = new Dictionary<int, long>();
            foreach (var task in tasks)
            {
                days = Math.Max(days, dict.GetValueOrDefault(task, long.MinValue) + space) + 1;
                dict[task] = days;
            }

            return days;
        }
    }
}
