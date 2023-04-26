using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.BiWeekly90
{
    public class _6228WordsWithinTwoEditsofDictionary
    {
        public IList<string> TwoEditWords(string[] queries, string[] dictionary)
        {
            var result = new List<string>();
            for (var i = 0; i < queries.Length; i++)
            {
                var query = queries[i];
                foreach (var word in dictionary)
                {
                    var delta = 0;
                    for (var j = 0; j < word.Length; j++)
                    {
                        if (query[j] != word[j]) delta++;
                    }

                    if (delta <= 2)
                    {
                        result.Add(query);
                        break;
                    }
                }
            }

            return result;
        }
    }
}
