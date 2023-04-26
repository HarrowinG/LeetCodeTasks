namespace LeetCodeTasks._509FibonacciNumber
{
    public class FibonacciNumber
    {
        public int Fib(int n)
        {
            return BottomUp(n);
            //return TopDown(n);
        }

        private int BottomUp(int n)
        {
            if (n < 2) return n;
            var first = 0;
            var second = 1;
            for (int i = 2; i <= n; i++)
            {
                var current = first + second;
                first = second;
                second = current;
            }

            return second;
        }

        private int TopDown(int n)
        {
            var memo = new int[n + 1];
            return Dfs(n, memo);
        }

        private int Dfs(int n, int[] memo)
        {
            if (n < 2) return n;
            if (memo[n] != 0) return memo[n];

            memo[n] = Dfs(n - 2, memo) + Dfs(n - 1, memo);
            return memo[n];
        }
    }
}
