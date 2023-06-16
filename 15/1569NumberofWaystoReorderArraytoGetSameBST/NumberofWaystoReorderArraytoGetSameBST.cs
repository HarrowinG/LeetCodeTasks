namespace LeetCodeTasks._1569NumberofWaystoReorderArraytoGetSameBST
{
    public class NumberofWaystoReorderArraytoGetSameBST
    {
        private const long Modulo = (long)1e9 + 7;

        public int NumOfWays(int[] nums)
        {
            return (int)GetCombinations(nums.ToList(), GetPascalTriangle(nums.Length + 1)) - 1;
        }

        private long GetCombinations(List<int> nums, long[][] combinations)
        {
            if (nums.Count <= 2) return 1;

            int root = nums[0];
            var left = new List<int>();
            var right = new List<int>();
            foreach (var n in nums)
            {
                if (n < root) left.Add(n);
                else if (n > root) right.Add(n);
            }
            
            return (combinations[left.Count + right.Count][left.Count] * (GetCombinations(left, combinations) % Modulo) % Modulo)
                * GetCombinations(right, combinations) % Modulo;
        }

        private long[][] GetPascalTriangle(int n)
        {
            var triangle = new long[n][];
            for (int i = 0; i < n; i++)
            {
                triangle[i] = new long[n];
                triangle[i][0] = triangle[i][i] = 1;
            }
            for (int i = 2; i < n; i++)
                for (int j = 1; j < i; j++)
                    triangle[i][j] = (triangle[i - 1][j] + triangle[i - 1][j - 1]) % Modulo;

            return triangle;
        }
    }
}
