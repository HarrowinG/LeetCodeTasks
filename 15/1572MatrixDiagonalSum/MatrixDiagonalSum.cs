namespace LeetCodeTasks._1572MatrixDiagonalSum
{
    public class MatrixDiagonalSum
    {
        public int DiagonalSum(int[][] mat)
        {
            var sum = 0;
            for (var i = 0; i < mat.Length; i++)
            {
                var j = mat.Length - 1 - i;
                sum += mat[i][i];
                sum += mat[i][j];
            }

            if (mat.Length % 2 != 0)
            {
                var mid = mat.Length / 2;
                sum -= mat[mid][mid];
            }

            return sum;
        }
    }
}
