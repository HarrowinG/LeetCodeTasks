using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly334
{
    public class FindtheDivisibilityArrayofaString
    {
        public int[] DivisibilityArray(string word, int m)
        {
            var result = new int[word.Length];
            long num = 0;
            for (var i = 0; i < word.Length; i++)
            {
                var c = word[i] - '0';
                num = num * 10 + c;
                num %= m;
                result[i] = num == 0 ? 1 : 0;
            }

            return result;
        }
    }
}
