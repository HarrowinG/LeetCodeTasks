namespace LeetCodeTasks._73SetMatrixZeroes
{
    public class SetMatrixZeroes
    {
        public void SetZeroes(int[][] matrix)
        {
            var zeroCorner = false;
            for (var i = 0; i < matrix.Length; i++)
            {
                for (var j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        matrix[0][j] = 0;
                        if (i > 0) matrix[i][0] = 0;
                        else zeroCorner = true;
                    }
                }
            }

            for (var i = matrix.Length - 1; i >= 1; i--)
            {
                if (matrix[i][0] == 0)
                {
                    for (var j = 0; j < matrix[i].Length; j++) matrix[i][j] = 0;
                }
            }

            for (var j = matrix[0].Length - 1; j >= 0; j--)
            {
                if (matrix[0][j] == 0)
                {
                    for (var i = 0; i < matrix.Length; i++) matrix[i][j] = 0;
                }
            }

            if (zeroCorner)
            {
                for (var j = 0; j < matrix[0].Length; j++) matrix[0][j] = 0;
            }
        }
    }
}
