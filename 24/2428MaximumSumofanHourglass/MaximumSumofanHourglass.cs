namespace LeetCodeTasks._2428MaximumSumofanHourglass
{
    public class MaximumSumofanHourglass
    {
        public int MaxSum(int[][] grid)
        {
            var max = 0;
            for (var i = 0; i < grid.Length - 2; i++)
            {
                for (var j = 0; j < grid[i].Length - 2; j++)
                {
                    var sum = grid[i][j] + grid[i][j + 1] + grid[i][j + 2]
                                         + grid[i + 1][j + 1]
                            + grid[i + 2][j] + grid[i + 2][j + 1] + grid[i + 2][j + 2];
                    max = Math.Max(max, sum);
                }
            }

            return max;
        }
    }
}
