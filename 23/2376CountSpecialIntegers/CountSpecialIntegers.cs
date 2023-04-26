namespace LeetCodeTasks._2376CountSpecialIntegers
{
    public class CountSpecialIntegers
    {
        public int CountSpecialNumbers(int n)
        {
            var s = n.ToString();
            var res = 0;
            for (int i = 1; i < s.Length; i++)
            {
                res += 9 * Count(i - 1, 9);
            }

            res += Dfs(0, 0, s);
            return res;
        }

        public int Dfs(int i, int mask, string s)
        {
            if (i >= s.Length) return 1;

            var res = 0;
            var cur = s[i] - '0';
            for (int j = i > 0 ? 0 : 1; j < cur; j++)
            {
                if ((mask & (1 << j)) == 0)
                {
                    res += Count(s.Length - i - 1, 9 - i);
                }
            }

            return res + ((mask & (1 << cur)) == 0 ? Dfs(i + 1, mask + (1 << cur), s) : 0);
        }

        private int Count(int l, int possibilities)
        {
            return l == 0 ? 1 : Count(l - 1, possibilities) * (possibilities - l + 1);
        }
    }
}
