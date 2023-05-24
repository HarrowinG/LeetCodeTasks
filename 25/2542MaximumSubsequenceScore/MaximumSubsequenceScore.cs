namespace LeetCodeTasks._2542MaximumSubsequenceScore
{
    public class MaximumSubsequenceScore
    {
        public long MaxScore(int[] nums1, int[] nums2, int k)
        {
            var pairs = new int[nums1.Length][];
            for (int i = 0; i < nums1.Length; i++)
                pairs[i] = new int[] { nums2[i], nums1[i] };
            Array.Sort(pairs, Comparer<int[]>.Create((a, b) => b[0].CompareTo(a[0])));

            var pq = new PriorityQueue<int, int>();
            long res = 0, sum = 0;
            foreach (var pair in pairs)
            {
                pq.Enqueue(pair[1], pair[1]);
                sum += pair[1];
                if (pq.Count > k) sum -= pq.Dequeue();
                if (pq.Count == k) res = Math.Max(res, sum * pair[0]);
            }

            return res;
        }
    }
}
