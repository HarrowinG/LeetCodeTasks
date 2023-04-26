namespace LeetCodeTasks._62UniquePaths
{
    public class UniquePathsClass
    {
        public int UniquePaths(int m, int n)
        {
            var row = new int[n];
            Array.Fill(row, 1);

            for (var i = 1; i < m; i++)
            {
                var current = new int[n];
                current[0] = 1;
                for (var j = 1; j < n; j++)
                {
                    current[j] = current[j - 1] + row[j];
                }

                row = current;
            }

            return row[n - 1];
        }
    }
}
