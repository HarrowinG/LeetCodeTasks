using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.BiWeekly94
{
    public class _6295MinimizetheMaximumofTwoArrays
    {
        public int MinimizeSet(int divisor1, int divisor2, int uniqueCnt1, int uniqueCnt2)
        {
            return New(divisor1, divisor2, uniqueCnt1, uniqueCnt2);
        }

        //OOM
        private int New(int divisor1, int divisor2, int uniqueCnt1, int uniqueCnt2)
        {
            var memo = new Dictionary<(int, int, int), int>();
            return Dfs(divisor1, divisor2, uniqueCnt1, uniqueCnt2, 1, memo);
        }

        private int Dfs(int divisor1, int divisor2, int uniqueCnt1, int uniqueCnt2, int i, Dictionary<(int, int, int), int> memo)
        {
            if (uniqueCnt1 == 0 && uniqueCnt2 == 0) return i - 1;

            var key = (uniqueCnt1, uniqueCnt2, i);
            if (!memo.ContainsKey(key) || memo[key] == 0)
            {
                if (uniqueCnt1 > 0 && i % divisor1 != 0)
                {
                    if (uniqueCnt2 > 0 && i % divisor2 != 0)
                    {
                        var first = Dfs(divisor1, divisor2, uniqueCnt1 - 1, uniqueCnt2, i + 1, memo);
                        var second = Dfs(divisor1, divisor2, uniqueCnt1, uniqueCnt2 - 1, i + 1, memo);
                        memo[key] = Math.Min(first, second);
                    }
                    else memo[key] = Dfs(divisor1, divisor2, uniqueCnt1 - 1, uniqueCnt2, i + 1, memo);
                }
                else if (uniqueCnt2 > 0 && i % divisor2 != 0)
                    memo[key] = Dfs(divisor1, divisor2, uniqueCnt1, uniqueCnt2 - 1, i + 1, memo);
                else
                    memo[key] = Dfs(divisor1, divisor2, uniqueCnt1, uniqueCnt2, i + 1, memo);

                memo[key] += 1;
            }

            return memo[key] - 1;
        }
    }
}
