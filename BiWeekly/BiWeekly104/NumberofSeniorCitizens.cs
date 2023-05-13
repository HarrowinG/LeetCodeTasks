using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.BiWeekly104
{
    public class NumberofSeniorCitizens
    {
        public int CountSeniors(string[] details)
        {
            return details.Where(x => int.Parse(x[11..13]) > 60).Count();
        }
    }
}
