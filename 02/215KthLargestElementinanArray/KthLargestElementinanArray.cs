namespace LeetCodeTasks._215KthLargestElementinanArray
{
    public class KthLargestElementinanArray
    {
        //can de done with quick select O(n) average n^2 worst
        public int FindKthLargest(int[] nums, int k)
        {
            var queue = new PriorityQueue<int, int>();
            foreach (int num in nums)
            {
                if (queue.Count == k)
                {
                    var item = queue.Peek();
                    if (num > item)
                    {
                        queue.Dequeue();
                        queue.Enqueue(num, num);
                    }
                }
                else
                {
                    queue.Enqueue(num, num);
                }
            }

            return queue.Dequeue();
        }
    }
}
