namespace LeetCodeTasks._48RotateImage
{
    public class RotateImage
    {
        public void Rotate(int[][] matrix)
        {
            var n = matrix.Length;
            var size = matrix.Length;
            var start = 0;
            while (size > 1)
            {
                for (var i = start; i < start + size - 1; i++)
                {
                    var temp = matrix[start][i];
                    matrix[start][i] = matrix[n - i - 1][start];
                    matrix[n - i - 1][start] = matrix[n - start - 1][n - i - 1];
                    matrix[n - start - 1][n - i - 1] = matrix[i][n - start - 1];
                    matrix[i][n - start - 1] = temp;
                }

                size -= 2;
                start++;
            }
        }
    }
}
