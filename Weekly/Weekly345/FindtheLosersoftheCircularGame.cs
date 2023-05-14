using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly345
{
    public class FindtheLosersoftheCircularGame
    {
        public int[] CircularGameLosers(int n, int k)
        {
            var set = Enumerable.Range(2, n - 1).ToHashSet();
            var i = 1;
            var current = 1;
            while (true)
            {
                current = (current + i * k) % n;
                if (current == 0) current = n;

                if (set.Contains(current)) set.Remove(current);
                else break;
                i++;
            }

            return set.ToArray();
        }
    }
}
