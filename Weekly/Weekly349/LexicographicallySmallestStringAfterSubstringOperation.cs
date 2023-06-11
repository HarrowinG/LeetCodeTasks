using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly349
{
    public class LexicographicallySmallestStringAfterSubstringOperation
    {
        public string SmallestString(string s)
        {
            var arr = s.ToCharArray();
            var i = 0;
            while (i < arr.Length && arr[i] == 'a') i++;
            if (i == arr.Length)
            {
                arr[i - 1] = 'z';
                return new string(arr);
            }

            while (i < arr.Length && arr[i] != 'a')
            {
                arr[i]--;
                i++;
            }

            return new string(arr);
        }
    }
}
