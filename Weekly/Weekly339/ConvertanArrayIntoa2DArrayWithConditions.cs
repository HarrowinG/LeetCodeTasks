using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly339
{
    public class ConvertanArrayIntoa2DArrayWithConditions
    {
        public IList<IList<int>> FindMatrix(int[] nums)
        {
            var sets = new List<HashSet<int>> { new HashSet<int>() };
            foreach (var num in nums)
            {
                var wasAdded = false;
                for (var i = 0; i < sets.Count; i++)
                {
                    if (!sets[i].Contains(num))
                    {
                        sets[i].Add(num);
                        wasAdded = true;
                        break;
                    }
                }

                if (!wasAdded)
                    sets.Add(new HashSet<int> { num });
            }

            var result = new List<IList<int>>();
            foreach (var set in sets)
                result.Add(set.ToList());

            return result;
        }
    }
}
