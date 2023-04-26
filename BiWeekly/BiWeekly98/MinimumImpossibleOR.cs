using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.BiWeekly98
{
    public class MinimumImpossibleOR
    {
        public int MinImpossibleOR(int[] nums)
        {
            var set = new HashSet<int>(nums);
            var res = 1;
            while (set.Contains(res))
                res *= 2;

            return res;
        }
    }
}
