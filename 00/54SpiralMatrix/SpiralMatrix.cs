namespace LeetCodeTasks._54SpiralMatrix
{
    public class SpiralMatrix
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            var result = new List<int>();
            var top = 0;
            var bottom = matrix.Length;
            var left = 0;
            var right = matrix[0].Length;
            
            while (top < bottom && left < right)
            {
                for (var i = left; i < right; i++) result.Add(matrix[top][i]);
                top++;
                for (var i = top; i < bottom; i++) result.Add(matrix[i][right - 1]);
                right--;

                if (top >= bottom || left >= right) break;

                for (var i = right - 1; i >= left; i--) result.Add(matrix[bottom - 1][i]);
                bottom--;
                for (var i = bottom - 1; i >= top; i--) result.Add(matrix[i][left]);
                left++;
            }

            return result;
        }
    }
}
