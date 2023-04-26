using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly316
{
    public class _6214DetermineifwoEventsHaveConflict
    {
        public bool HaveConflict(string[] event1, string[] event2)
        {
            var s1 = int.Parse(event1[0].Substring(0, 2)) * 60 + int.Parse(event1[0].Substring(3, 2));
            var e1 = int.Parse(event1[1].Substring(0, 2)) * 60 + int.Parse(event1[1].Substring(3, 2));

            var s2 = int.Parse(event2[0].Substring(0, 2)) * 60 + int.Parse(event2[0].Substring(3, 2));
            var e2 = int.Parse(event2[1].Substring(0, 2)) * 60 + int.Parse(event2[1].Substring(3, 2));

            if (e1 >= s2 && e2 >= s1) return true;
            return false;
        }
    }
}
