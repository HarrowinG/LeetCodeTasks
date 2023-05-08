using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly344
{
    public class FrequencyTracker
    {
        private readonly Dictionary<int, HashSet<int>> _frequency = new();
        private readonly int[] nums = new int[100001];

        public FrequencyTracker() { }

        public void Add(int number)
        {
            nums[number]++;
            var numberCount = nums[number];
            _frequency[numberCount] = _frequency.GetValueOrDefault(numberCount, new HashSet<int>());
            _frequency[numberCount].Add(number);

            _frequency[numberCount - 1] = _frequency.GetValueOrDefault(numberCount - 1, new HashSet<int>());
            _frequency[numberCount - 1].Remove(number);
        }

        public void DeleteOne(int number)
        {
            if (nums[number] == 0) return;

            nums[number]--;
            var numberCount = nums[number];
            _frequency[numberCount] = _frequency.GetValueOrDefault(numberCount, new HashSet<int>());
            _frequency[numberCount].Add(number);

            _frequency[numberCount + 1] = _frequency.GetValueOrDefault(numberCount + 1, new HashSet<int>());
            _frequency[numberCount + 1].Remove(number);
        }

        public bool HasFrequency(int frequency)
        {
            return _frequency.GetValueOrDefault(frequency, new HashSet<int>()).Count > 0;
        }
    }
}
