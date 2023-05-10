namespace LeetCodeTasks._59SpiralMatrixII
{
    public class SpiralMatrixII
    {
        public int[][] GenerateMatrix(int n)
        {
            var matrix = new int[n][];
            for (var i = 0; i < n; i++)
                matrix[i] = new int[n];

            var top = 0;
            var bottom = matrix.Length;
            var left = 0;
            var right = matrix[0].Length;
            var num = 1;

            while (top < bottom && left < right)
            {
                for (var i = left; i < right; i++) matrix[top][i] = num++;
                top++;
                for (var i = top; i < bottom; i++) matrix[i][right - 1] = num++;
                right--;

                if (top >= bottom || left >= right) break;

                for (var i = right - 1; i >= left; i--) matrix[bottom - 1][i] = num++;
                bottom--;
                for (var i = bottom - 1; i >= top; i--) matrix[i][left] = num++;
                left++;
            }

            return matrix;
        }
    }
}
