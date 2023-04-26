namespace LeetCodeTasks._1220CountVowelPermutation
{
    public class CountVowelPermutationClass
    {
        public int CountVowelPermutation(int n)
        {
            var modulo = 1000000000 + 7;
            var row = new int[5];
            Array.Fill(row, 1);

            for (var i = 1; i < n; i++)
            {
                var current = new int[5];
                current[0] = ((row[1] + row[2]) % modulo + row[4]) % modulo;
                current[1] = (row[0] + row[2]) % modulo;
                current[2] = (row[1] + row[3]) % modulo;
                current[3] = row[2];
                current[4] = (row[2] + row[3]) % modulo;
                row = current;
            }

            var sum = 0;
            foreach (var num in row)
            {
                sum = sum = (sum + num) % modulo;
            };
            return sum;
        }
    }
}
