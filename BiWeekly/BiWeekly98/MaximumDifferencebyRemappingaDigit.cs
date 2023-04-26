using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.BiWeekly98
{
    public class MaximumDifferencebyRemappingaDigit
    {
        public int MinMaxDifference(int num)
        {
            var strNum = num.ToString();
            char maxToChange = strNum[0];
            char minToChange = strNum[0];
            var max = new StringBuilder(strNum.Length);
            var min = new StringBuilder(strNum.Length);
            for (var i = 0; i < strNum.Length; i++)
            {
                if (strNum[i] != '9')
                {
                    maxToChange = strNum[i];
                    break;
                }
            }
            for (var i = 0; i < strNum.Length; i++)
            {
                if (strNum[i] != '0')
                {
                    minToChange = strNum[i];
                    break;
                }
            }
            for (var i = 0; i < strNum.Length; i++)
            {
                max.Append(strNum[i] == maxToChange ? '9' : strNum[i]);
                min.Append(strNum[i] == minToChange ? '0' : strNum[i]);
            }

            return int.Parse(max.ToString()) - int.Parse(min.ToString());
        }
    }
}
