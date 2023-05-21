using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly346
{
    public class FindthePunishmentNumberofanInteger
    {
        public int PunishmentNumber(int n)
        {
            var punishers = new List<int>();
            for (var i = 1; i <= n; i++)
            {
                if (IsPunisher((i * i).ToString(), i))
                    punishers.Add(i);
            }

            return punishers.Sum(x => x * x);
        }

        private bool IsPunisher(string s, int num)
        {
            if (num < 0) return false;
            if (s.Length == 0 && num == 0) return true;

            for (var i = 1; i <= s.Length; i++)
            {
                var subStr = s[0..i];
                var n = int.Parse(subStr);
                if (IsPunisher(s[i..s.Length], num - n))
                    return true;
            }

            return false;
        }
    }
}
