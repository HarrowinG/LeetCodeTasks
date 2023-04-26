namespace LeetCodeTasks._703KthLargestElementinaStream
{
    public class KthLargest
    {
        private PriorityQueue<int, int> _queue = new();
        private int _k;

        public KthLargest(int k, int[] nums)
        {
            _k = k;
            foreach (int i in nums)
            {
                Add(i);
            }
        }

        public int Add(int val)
        {
            if (_queue.Count < _k)
            {
                _queue.Enqueue(val, val);
            }
            else
            {
                if (val > _queue.Peek())
                {
                    _queue.Enqueue(val, val);
                    _queue.Dequeue();
                }
            }

            return _queue.Peek();
        }
    }
}
