namespace LeetCodeTasks._2382MaximumSegmentSumAfterRemovals
{
    public class MaximumSegmentSumAfterRemovals
    {
        public long[] MaximumSegmentSum(int[] nums, int[] removeQueries)
        {
            //return PrefixSumPriorityQueue(nums, removeQueries);
            return ReverseDsu(nums, removeQueries);
        }

        private class Dsu
        {
            private Dictionary<int, int> _dsu = new Dictionary<int, int>();
            private Dictionary<int, long> _sum = new Dictionary<int, long>();
            public long MaxSum { get; private set; }

            public void UpdateMaxSum(long val)
            {
                MaxSum = Math.Max(MaxSum, val);
            }

            public int Find(int x)
            {
                var y = _dsu.GetValueOrDefault(x, x);
                if (y != x)
                {
                    y = Find(y);
                    _dsu[x] = y;
                }

                return y;
            }

            public void Union(int x, int y, int[] nums)
            {
                var xParent = Find(x);
                var yParent = Find(y);
                _sum[yParent] = _sum.GetValueOrDefault(yParent, nums[yParent]) + _sum.GetValueOrDefault(xParent, nums[xParent]);
                if (_sum.ContainsKey(xParent)) _sum.Remove(xParent);
                MaxSum = Math.Max(MaxSum, _sum[yParent]);
                _dsu[xParent] = yParent;
            }
        }

        private long[] ReverseDsu(int[] nums, int[] removeQueries)
        {
            var n = nums.Length;
            var result = new long[n];
            var boundries = new HashSet<int>();
            var dsu = new Dsu();
            for (var i = n - 1; i > 0; i--)
            {
                var removeId = removeQueries[i];
                boundries.Add(removeId);
                var united = false;
                if (boundries.Contains(removeId - 1))
                {
                    dsu.Union(removeId - 1, removeId, nums);
                    united = true;
                }
                if (boundries.Contains(removeId + 1))
                {
                    dsu.Union(removeId + 1, removeId, nums);
                    united = true;
                }
                if (!united) dsu.UpdateMaxSum(nums[removeId]);

                result[i - 1] = dsu.MaxSum;
            }

            return result;
        }

        private long[] PrefixSumPriorityQueue(int[] nums, int[] removeQueries)
        {
            var n = nums.Length;
            var result = new long[n];
            var boundries = new SortedSet<int> { -1, n };
            var prefixSums = new long[n];
            var pq = new PriorityQueue<(int s, int e, long sum), long>(Comparer<long>.Create((a, b) => b.CompareTo(a)));

            prefixSums[0] = nums[0];
            for (int i = 1; i < n; i++)
            {
                prefixSums[i] = nums[i] + prefixSums[i - 1];
            }

            pq.Enqueue((0, n - 1, prefixSums[n - 1]), prefixSums[n - 1]);
            for (var i = 0; i < n; i++)
            {
                var removeId = removeQueries[i];
                boundries.Add(removeId);
                var s = boundries.GetViewBetween(-1, removeId - 1).Max;
                var e = boundries.GetViewBetween(removeId + 1, n).Min;

                if (s + 1 < removeId)
                {
                    long sum = prefixSums[removeId - 1] - (s == -1 ? 0 : prefixSums[s]);
                    pq.Enqueue((s + 1, removeId - 1, sum), sum);
                }
                if (e - 1 > removeId)
                {
                    long sum = prefixSums[e - 1] - prefixSums[removeId];
                    pq.Enqueue((removeId + 1, e - 1, sum), sum);
                }

                while (pq.Count > 0)
                {
                    var item = pq.Peek();
                    var bound = boundries.GetViewBetween(item.s, n).Min;
                    if (bound <= item.e)
                    {
                        pq.Dequeue();
                    }
                    else
                    {
                        result[i] = item.sum;
                        break;
                    }
                }
            }

            return result;
        }
    }
}
