namespace LeetCodeTasks._2404MostFrequentEvenElement
{
    public class MostFrequentEvenElement
    {
        public int MostFrequentEven(int[] nums)
        {
            var max = 0;
            var element = -1;
            var dict = new SortedDictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 != 0) continue;

                var current = nums[i];
                dict[current] = dict.GetValueOrDefault(current, 0) + 1;
                if (dict[current] > max || (dict[current] == max && current < element))
                {
                    max = dict[current];
                    element = current;
                }
            }

            return element;
        }
    }
}
