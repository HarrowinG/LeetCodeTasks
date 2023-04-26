using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.BiWeekly100
{
    public class DistributeMoneytoMaximumChildren
    {
        public int DistMoney(int money, int children)
        {
            var numOf8 = money / 8;
            var rest = money - numOf8 * 8;

            if (numOf8 == children)
            {
                if (rest == 0) return children;
                return children - 1;
            }
            else if (numOf8 > children) return children - 1;

            var childsLeft = children - numOf8;
            if (childsLeft == 1 && rest == 4) return -1;
            if (childsLeft > rest) return numOf8 - 1;

            return numOf8;
        }
    }
}
