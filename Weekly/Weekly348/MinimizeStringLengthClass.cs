using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly348
{
    public class MinimizeStringLengthClass
    {
        public int MinimizedStringLength(string s)
        {
            return s.Distinct().Count();
        }
    }
}
