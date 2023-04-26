using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly317
{
    public class _6221MostPopularVideoCreator
    {
        public IList<IList<string>> MostPopularCreator(string[] creators, string[] ids, int[] views)
        {
            var result = new List<IList<string>>();
            var dictSum = new Dictionary<string, long>();
            var dictMax = new Dictionary<string, int>();
            long overollMax = 0;
            for (var i = 0; i < creators.Length; i++)
            {
                dictSum[creators[i]] = dictSum.GetValueOrDefault(creators[i], 0);
                dictSum[creators[i]] += views[i];
                overollMax = Math.Max(overollMax, dictSum[creators[i]]);

                if (!dictMax.ContainsKey(creators[i]))
                {
                    dictMax[creators[i]] = i;
                }

                var max = views[dictMax[creators[i]]];
                if (views[i] == max)
                {
                    var compare = string.Compare(ids[dictMax[creators[i]]], ids[i]);
                    if (compare > 0)
                        dictMax[creators[i]] = i;
                }
                else if (views[i] > max)
                    dictMax[creators[i]] = i;
            }

            foreach (var s in dictSum)
            {
                if (s.Value == overollMax)
                    result.Add(new List<string> { s.Key, ids[dictMax[s.Key]] });
            }

            return result;
        }
    }
}
