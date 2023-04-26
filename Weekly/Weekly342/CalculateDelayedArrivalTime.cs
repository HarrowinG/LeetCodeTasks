using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly342
{
    public class CalculateDelayedArrivalTime
    {
        public int FindDelayedArrivalTime(int arrivalTime, int delayedTime)
        {
            return (arrivalTime + delayedTime) % 24;
        }
    }
}
