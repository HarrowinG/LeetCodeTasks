namespace LeetCodeTasks._2373LargestLocalValuesinaMatrix
{
    public class LargestLocalValuesinaMatrix
    {
        public int[][] LargestLocal(int[][] grid)
        {
            var n = grid.Length;
            var result = new int[n - 2][];
            for (int i = 0; i < n - 2; i++)
            {
                result[i] = new int[n - 2];
                for (int j = 0; j < n - 2; j++)
                    for (int ii = i; ii < i + 3; ii++)
                        for (int jj = j; jj < j + 3; jj++)
                            result[i][j] = Math.Max(result[i][j], grid[ii][jj]);
            }

            return result;
        }
    }
}
