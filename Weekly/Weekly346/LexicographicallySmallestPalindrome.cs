using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly346
{
    public class LexicographicallySmallestPalindrome
    {
        public string MakeSmallestPalindrome(string s)
        {
            var arr = s.ToCharArray();
            var l = 0;
            var r = arr.Length - 1;
            while (l < r)
            {
                if (arr[l] < arr[r])
                    arr[r] = arr[l];
                else if (arr[l] > arr[r])
                    arr[l] = arr[r];
                l++;
                r--;
            }

            return new string(arr);
        }
    }
}
