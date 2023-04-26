namespace LeetCodeTasks._2426NumberofPairsSatisfyingInequality
{
    public class NumberofPairsSatisfyingInequality
    {
        public long NumberOfPairs(int[] nums1, int[] nums2, int diff)
        {
            //return BsOnList(nums1, nums2, diff);
            return MergeSegTree(nums1, nums2, diff);
        }

        private class MergeSortTree
        {
            private readonly List<int>[] _arr;
            private readonly int _size;

            public MergeSortTree(int[] nums)
            {
                _size = 1;
                while (_size < nums.Length) _size <<= 1;
                _arr = new List<int>[2 * _size];
                Build(0, _size - 1, 0, nums);
            }

            private void Build(int l, int r, int id, int[] nums)
            {
                if (id < _arr.Length && _arr[id] == null) _arr[id] = new List<int>();
                if (l == r)
                {
                    if (l < nums.Length)
                    {
                        _arr[id].Add(nums[l]);
                    }
                    return;
                }
                var mid = l + (r - l) / 2;
                Build(l, mid, 2 * id + 1, nums);
                Build(mid + 1, r, 2 * id + 2, nums);

                Merge(_arr[id], _arr[2 * id + 1], _arr[2 * id + 2]);
            }

            private void Merge(IList<int> a, IList<int> b, IList<int> c)
            {
                int i = 0, j = 0;
                while (i < b.Count && j < c.Count)
                    if (b[i] < c[j]) a.Add(b[i++]);
                    else a.Add(c[j++]);
                while (i < b.Count)
                    a.Add(b[i++]);
                while (j < c.Count)
                    a.Add(c[j++]);
            }

            public int Query(int lRequested, int rRequested, int value)
            {
                return Query(lRequested, rRequested, value, 0, 0, _size - 1);
            }

            private int Query(int lRequested, int rRequested, int value, int id, int l, int r)
            {
                if (l > rRequested || r < lRequested) return 0;
                if (l >= lRequested && r <= rRequested)
                    return Bs(_arr[id], value);

                var mid = l + (r - l) / 2;
                return Query(lRequested, rRequested, value, 2 * id + 1, l, mid)
                     + Query(lRequested, rRequested, value, 2 * id + 2, mid + 1, r);

                int Bs(IList<int> list, int value)
                {
                    var l = 0;
                    var r = list.Count - 1;
                    while (l <= r)
                    {
                        var mid = l + (r - l) / 2;
                        if (list[mid] <= value) l = mid + 1;
                        else r = mid - 1;
                    }

                    return l;
                }
            }
        }

        private long MergeSegTree(int[] nums1, int[] nums2, int diff)
        {
            var result = 0L;
            var nums = new int[nums1.Length];
            for (var i = 0; i < nums1.Length; i++)
                nums[i] = nums1[i] - nums2[i];

            var segTree = new MergeSortTree(nums);
            for (var i = 1; i < nums.Length; i++)
                result += segTree.Query(0, i - 1, nums[i] + diff);

            return result;
        }

        //----------------------------------------------------------------
        private long BsOnList(int[] nums1, int[] nums2, int diff)
        {
            var result = 0L;
            var list = new List<int>();
            for (var i = 0; i < nums1.Length; i++)
            {
                var res = nums1[i] - nums2[i];
                result += Bs(list, res + diff);
                list.Insert(Bs(list, res), res);
            }

            return result;
        }

        private int Bs(IList<int> list, int target)
        {
            var l = 0;
            var r = list.Count - 1;
            while (l <= r)
            {
                var mid = l + (r - l) / 2;
                if (list[mid] <= target) l = mid + 1;
                else r = mid - 1;
            }

            return l;
        }
    }
}
