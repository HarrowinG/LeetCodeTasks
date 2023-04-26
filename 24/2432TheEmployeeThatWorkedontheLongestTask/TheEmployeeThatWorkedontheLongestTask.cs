namespace LeetCodeTasks._2432TheEmployeeThatWorkedontheLongestTask
{
    public class TheEmployeeThatWorkedontheLongestTask
    {
        public int HardestWorker(int n, int[][] logs)
        {
            var id = logs[0][0];
            var time = logs[0][1];
            for (var i = 1; i < logs.Length; i++)
            {
                var delta = logs[i][1] - logs[i - 1][1];
                if (delta > time)
                {
                    time = delta;
                    id = logs[i][0];
                }
                else if (delta == time)
                {
                    id = Math.Min(id, logs[i][0]);
                }
            }

            return id;
        }
    }
}
