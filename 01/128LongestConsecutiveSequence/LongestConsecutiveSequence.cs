namespace LeetCodeTasks._128LongestConsecutiveSequence
{
    public class LongestConsecutiveSequence
    {
        public int LongestConsecutive(int[] nums)
        {
            return UnionFind(nums);
            //return Hash(nums);
        }

        public int Hash(int[] nums)
        {
            var max = nums.Length > 0 ? 1 : 0;
            var set = new HashSet<int>(nums);
            foreach (var num in nums)
            {
                if (set.Contains(num - 1)) continue;

                var next = num + 1;
                while (set.Contains(next))
                    next++;
                max = Math.Max(max, next - num);
            }

            return max;
        }

        public int UnionFind(int[] nums)
        {
            var max = nums.Length > 0 ? 1 : 0;
            var set = new HashSet<int>();
            var dsu = new Dsu();
            foreach (int num in nums)
            {
                if (set.Contains(num)) continue;
                set.Add(num);

                if (set.Contains(num - 1))
                    max = Math.Max(max, dsu.Union(num - 1, num));
                if (set.Contains(num + 1))
                    max = Math.Max(max, dsu.Union(num + 1, num));
            }

            return max;
        }

        private class Dsu
        {
            private Dictionary<int, int> _dsu = new();
            private Dictionary<int, int> _rank = new();

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

            public int Union(int x, int y)
            {
                var px = Find(x);
                var py = Find(y);
                var rpx = _rank.GetValueOrDefault(px, 1);
                var rpy = _rank.GetValueOrDefault(py, 1);
                var rank = rpx + rpy;
                if (rpx > rpy)
                {
                    _rank[px] = rank;
                    _dsu[py] = px;
                }
                else
                {
                    _rank[py] = rank;
                    _dsu[px] = py;
                }

                return rank;
            }
        }
    }
}
