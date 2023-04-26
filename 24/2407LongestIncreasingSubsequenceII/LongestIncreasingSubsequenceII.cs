namespace LeetCodeTasks._2407LongestIncreasingSubsequenceII
{
    public class LongestIncreasingSubsequenceII
    {
        private class SegmentTree
        {
            private readonly int _n;
            private readonly int[] _tree;

            public SegmentTree(int n)
            {
                _n = n;
                _tree = new int[2 * n];
            }

            public int Query(int l, int r)
            {
                l += _n;
                r += _n;
                var result = 0;
                while (l < r)
                {
                    if ((l & 1) == 1)
                    {
                        result = Math.Max(result, _tree[l]);
                        l += 1;
                    }

                    if ((r & 1) == 1)
                    {
                        r -= 1;
                        result = Math.Max(result, _tree[r]);
                    }

                    l >>= 1;
                    r >>= 1;
                }

                return result;
            }

            public void Update(int i, int val)
            {
                i += _n;
                _tree[i] = val;
                while (i > 1)
                {
                    i >>= 1;
                    _tree[i] = Math.Max(_tree[i * 2], _tree[i * 2 + 1]);
                }
            }
        }

        public int LengthOfLIS(int[] nums, int k)
        {
            var n = nums.Max();
            var max = 1;
            var seg = new SegmentTree(n);
            for (var i = 0; i < nums.Length; i++)
            {
                var num = nums[i] - 1;
                var curmax = seg.Query(Math.Max(0, num - k), num);
                max = Math.Max(max, curmax + 1);
                seg.Update(num, curmax + 1);
            }

            return max;
        }
    }
}
