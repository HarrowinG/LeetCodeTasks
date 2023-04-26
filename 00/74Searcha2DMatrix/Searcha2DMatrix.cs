namespace LeetCodeTasks._74Searcha2DMatrix
{
    public class Searcha2DMatrix
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            //return SearchMatrix2Bs(matrix, target);
            return SearchMatrixAsList(matrix, target);
        }

        public bool SearchMatrixAsList(int[][] matrix, int target)
        {
            var m = matrix.Length;
            var n = matrix[0].Length;
            var l = 0; 
            var r = m * n - 1;
            while (l < r)
            {
                var mid = l + (r - l) / 2;
                if (matrix[mid / n][mid % n] < target) l = mid + 1;
                else r = mid;
            }

            return matrix[r / n][r % n] == target;
        }

        public bool SearchMatrix2Bs(int[][] matrix, int target)
        {
            var m = matrix.Length;
            var n = matrix[0].Length;
            var l = 0;
            var r = m - 1;
            while (l <= r)
            {
                var mid = l + (r - l) / 2;
                if (target < matrix[mid][0]) r = mid - 1;
                else if (target > matrix[mid][n - 1]) l = mid + 1;
                else return Bs(matrix[mid], target);
            }

            return false;
        }

        private bool Bs(int[] arr, int target)
        {
            var l = 0;
            var r = arr.Length - 1;
            while (l <= r)
            {
                var mid = l + (r - l) / 2;
                if (arr[mid] == target) return true;

                if (arr[mid] < target) l = mid + 1;
                else r = mid - 1;
            }

            return false;
        }
    }
}
