namespace LeetCodeTasks._981TimeBasedKeyValueStore
{
    public class TimeMap
    {
        private readonly Dictionary<string, List<(int Time, string Value)>> _store = new();
        public TimeMap() { }

        public void Set(string key, string value, int timestamp)
        {
            _store[key] = _store.GetValueOrDefault(key, new List<(int Time, string Value)>());
            _store[key].Add((timestamp, value));
        }

        public string Get(string key, int timestamp)
        {
            if (!_store.ContainsKey(key)) return string.Empty;

            var l = 0;
            var r = _store[key].Count - 1;
            var values = _store[key];
            var res = string.Empty;
            while (l <= r)
            {
                var mid = l + (r - l) / 2;
                if (values[mid].Time == timestamp) return _store[key][mid].Value;
                else if (values[mid].Time > timestamp) r = mid - 1;
                else
                {
                    res = _store[key][mid].Value;
                    l = mid + 1;
                }
            }

            return res;
        }
    }
}
