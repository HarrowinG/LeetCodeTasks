namespace LeetCodeTasks._347TopKFrequentElements
{
    public class TopKFrequentElements
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            var result = new List<int>();
            var buckets = new List<int>[nums.Length + 1];
            var dict = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                dict[num] = dict.GetValueOrDefault(num, 0) + 1;
            }

            foreach (var item in dict)
            {
                var freuency = item.Value;
                if (buckets[freuency] == null) buckets[freuency] = new List<int>();
                buckets[freuency].Add(item.Key);
            }

            for (var i = buckets.Length - 1; i >= 0; i--)
            {
                if (buckets[i] == null) continue;

                for (var j = 0; j < buckets[i].Count; j++)
                {
                    result.Add(buckets[i][j]);
                    if (result.Count == k) return result.ToArray();
                }
            }

            return result.ToArray();
        }
    }
}
