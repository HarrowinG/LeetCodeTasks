namespace LeetCodeTasks._2438RangeProductQueriesofPowers
{
    public class RangeProductQueriesofPowers
    {
        public int[] ProductQueries(int n, int[][] queries)
        {
            int modulo = 1000000007;
            var powers = new List<int>();
            for (var i = 0; i < 32; i++)
            {
                var power = 1 << i;
                if ((n & power) > 0) powers.Add(power);
            }

            var result = new List<int>(queries.Length);
            foreach (var query in queries)
            {
                var i = query[0];
                long product = powers[i++];
                while (i <= query[1])
                    product = (product * powers[i++]) % modulo;

                result.Add((int)product);
            }

            return result.ToArray();
        }
    }
}
