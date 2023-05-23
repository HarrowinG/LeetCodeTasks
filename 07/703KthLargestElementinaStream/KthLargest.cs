namespace LeetCodeTasks._703KthLargestElementinaStream
{
    public class KthLargest
    {
        readonly PriorityQueue<int, int> _queue = new();
        readonly int _k;

        public KthLargest(int k, int[] nums)
        {
            _k = k;
            foreach (var num in nums)
                _queue.Enqueue(num, num);
            while (_queue.Count > k)
                _queue.Dequeue();
        }

        public int Add(int val)
        {
            _queue.Enqueue(val, val);
            if (_queue.Count > _k)
                _queue.Dequeue();

            return _queue.Peek();
        }
    }
}
