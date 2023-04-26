using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.BiWeekly94
{
    public class _6273MaximumEnemyFortsThatCanBeCaptured
    {
        public int CaptureForts(int[] forts)
        {
            var result = 0;
            var current = 0;
            var count = 0;
            for (var i = 0; i < forts.Length; i++)
            {
                if (forts[i] == 1 || forts[i] == -1)
                {
                    if (current == forts[i] || current == 0)
                    {
                        current = forts[i];
                        count = 0;
                        continue;
                    }

                    current = forts[i];
                    result = Math.Max(result, count);
                    count = 0;
                    continue;
                }

                count++;
            }

            return result;
        }
    }
}
