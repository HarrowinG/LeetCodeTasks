namespace LeetCodeTasks._1146SnapshotArray
{
    public class SnapshotArray
    {
        readonly Dictionary<int, int>[] _snapshotArray;
        int _snapId = 0;

        public SnapshotArray(int length)
        {
            _snapshotArray = new Dictionary<int, int>[length];
            for (var i = 0; i < length; i++)
            {
                _snapshotArray[i] = new Dictionary<int, int> { { 0, 0 } };
            }
        }

        public void Set(int index, int val)
        {
            _snapshotArray[index][_snapId] = val;
        }

        public int Snap()
        {
            return _snapId++;
        }

        public int Get(int index, int snap_id)
        {
            var latestSnapId = GetLatestSnapshotId(_snapshotArray[index].Keys.ToList(), snap_id);
            return _snapshotArray[index][latestSnapId];
        }

        private int GetLatestSnapshotId(IList<int> keys, int snapId)
        {
            var l = 0; var r = keys.Count - 1;
            while (l <= r)
            {
                var mid = l + (r - l) / 2;
                if (keys[mid] == snapId) return keys[mid];
                if (keys[mid] < snapId) l = mid + 1;
                else r = mid - 1;
            }

            return keys[r];
        }
    }
}
