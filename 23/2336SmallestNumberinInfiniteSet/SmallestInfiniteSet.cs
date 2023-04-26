namespace LeetCodeTasks._2336SmallestNumberinInfiniteSet
{
    public class SmallestInfiniteSet
    {
        int _current = 1;
        readonly SortedSet<int> _set = new();

        public SmallestInfiniteSet() { }

        public int PopSmallest()
        {
            if (_set.Count > 0)
            {
                var smallest = _set.First();
                _set.Remove(smallest);
                return smallest;
            }

            return _current++;
        }

        public void AddBack(int num)
        {
            if (num < _current)
                _set.Add(num);
        }
    }
}
