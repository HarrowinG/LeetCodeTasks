using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.BiWeekly106
{
    public class CheckifTheNumberisFascinating
    {
        public bool IsFascinating(int n)
        {
            var str = n.ToString();
            str += 2 * n;
            str += 3 * n;
            var set = new int[10];
            foreach (char c in str)
            {
                if (c == '0') return false;
                set[c - '0']++;
            }

            for (var i = 1; i <= 9; i++)
                if (set[i] != 1) return false;

            return true;
        }
    }
}
