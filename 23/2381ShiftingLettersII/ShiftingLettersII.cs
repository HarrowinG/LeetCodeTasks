namespace LeetCodeTasks._2381ShiftingLettersII
{
    public class ShiftingLettersII
    {
        public string ShiftingLetters(string s, int[][] shifts)
        {
            return LineSweep(s, shifts);
            //return FenwickTree(s, shifts);
        }

        private string FenwickTree(string s, int[][] shifts)
        {
            var arr = s.ToCharArray();
            var moves = new int[s.Length + 1];
            foreach (var shift in shifts)
            {
                Add(moves, shift[0], shift[2] == 1 ? 1 : -1);
                Add(moves, shift[1] + 1, shift[2] == 1 ? -1 : 1);
            }

            for (int i = 0; i < s.Length; i++)
            {
                arr[i] = (char)('a' + (26 + (s[i] - 'a') + PrefixSum(moves, i) % 26) % 26);
            }

            return new string(arr);
        }

        private int PrefixSum(int[] moves, int i)
        {
            int sum = 0;
            for (i = i + 1; i > 0; i -= i & (-i))
                sum += moves[i];
            return sum;
        }

        private void Add(int[] moves, int i, int val)
        {
            for (i = i + 1; i < moves.Length; i += i & (-i))
                moves[i] += val;
        }

        private string LineSweep(string s, int[][] shifts)
        {
            var arr = s.ToCharArray();
            var moves = new int[s.Length + 1];
            foreach (var shift in shifts)
            {
                moves[shift[0]] += shift[2] == 1 ? 1 : -1;
                moves[shift[1] + 1] += shift[2] == 1 ? -1 : 1;
            }

            for (int i = 0, val = 0; i < s.Length; i++)
            {
                val = (val + moves[i]) % 26;
                arr[i] = (char)('a' + (26 + (s[i] - 'a') + val) % 26);
            }

            return new string(arr);
        }
    }
}
