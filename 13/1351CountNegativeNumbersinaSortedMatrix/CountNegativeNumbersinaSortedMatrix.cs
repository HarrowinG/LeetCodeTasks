namespace LeetCodeTasks._1351CountNegativeNumbersinaSortedMatrix
{
    public class CountNegativeNumbersinaSortedMatrix
    {
        public int CountNegatives(int[][] grid)
        {
            var result = 0;
            var n = grid[0].Length; var c = n - 1;
            for (var i = 0; i < grid.Length; i++)
            {
                while (c >= 0 && grid[i][c] < 0) c--;
                result += n - c - 1;
            }

            return result;
        }
    }
}
