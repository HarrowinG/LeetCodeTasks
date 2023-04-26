namespace LeetCodeTasks._2398MaximumNumberofRobotsWithinBudget
{
    public class MaximumNumberofRobotsWithinBudget
    {
        public int MaximumRobots(int[] chargeTimes, int[] runningCosts, long budget)
        {
            long sum = 0;
            var i = 0;
            var n = chargeTimes.Length;
            var dequeue = new LinkedList<int>();
            for (int j = 0; j < n; j++)
            {
                sum += runningCosts[j];
                while (dequeue.Count > 0 && chargeTimes[dequeue.Last.Value] <= chargeTimes[j])
                {
                    dequeue.RemoveLast();
                }
                
                dequeue.AddLast(j);
                if (chargeTimes[dequeue.First.Value] + (j - i + 1) * sum > budget)
                {
                    if (dequeue.First.Value == i) dequeue.RemoveFirst();
                    sum -= runningCosts[i];
                    i++;
                }
            }

            return n - i;
        }
    }
}
