namespace LeetCodeTasks._705DesignHashSet
{
    public class MyHashSet
    {
        readonly bool[] _set = new bool[(int)1e6 + 1];

        public MyHashSet() { }

        public void Add(int key)
        {
            _set[key] = true;
        }

        public void Remove(int key)
        {
            _set[key] = false;
        }

        public bool Contains(int key)
        {
            return _set[key];
        }
    }
}
