using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly346
{
    public class MinimumStringLengthAfterRemovingSubstrings
    {
        public int MinLength(string s)
        {
            var wasAction = true;
            while (wasAction)
            {
                var length = s.Length;
                s = s.Replace("AB", "");
                s = s.Replace("CD", "");
                if (length == s.Length) wasAction = false;
            }

            return s.Length;
        }
    }
}
