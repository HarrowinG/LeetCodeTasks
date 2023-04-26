using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly317
{
    public class _6222MinimumAdditiontoMakeIntegerBeautiful
    {
        public long MakeIntegerBeautiful(long n, int target)
        {
            var sum = 0;
            var strN = n.ToString();
            var list = new List<int>();
            for (var i = 0; i < strN.Length; i++)
            {
                var current = strN[i] - '0';
                if (sum + current > target)
                {
                    return CalculateX(strN, i, list);
                }
                sum += current;
                list.Add(current);
            }

            return 0;
        }

        private long CalculateX(string s, int id, List<int> list)
        {
            var n = long.Parse(s);
            if (id == 0)
                list.Add(1);

            //todo

            for (var i = id; i < s.Length; i++)
                list.Add(0);

            long val = list[0];
            for (var i = 1; i < list.Count; i++)
            {
                val *= 10;
                val += list[i];
            }

            return val - n;
        }
    }
}
