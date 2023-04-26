using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.BiWeekly90
{
    public class _6225OddStringDifference
    {
        public string OddString(string[] words)
        {
            var n = words[0].Length;
            var pos = 1;
            while (pos < n)
            {
                var delta = words[0][pos] - 'a' - words[0][pos - 1] - 'a';
                var dict = new Dictionary<int, (int delta, int id)>();
                dict[delta] = (1, 0);

                for (var i = 1; i < words.Length; i++)
                {
                    var currentDelta = words[i][pos] - 'a' - words[i][pos - 1] - 'a';
                    dict[currentDelta] = dict.GetValueOrDefault(currentDelta, (0, i));
                    dict[currentDelta] = (dict[currentDelta].delta + 1, i);
                }

                if (dict.Count > 1)
                {
                    foreach (var kvp in dict)
                        if (kvp.Value.delta == 1) return words[kvp.Value.id];
                }

                pos++;
            }

            return words[0];
        }
    }
}
