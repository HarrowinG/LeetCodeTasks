namespace LeetCodeTasks._2386FindtheKSumofanArray
{
    public class FindtheKSumofanArray
    {
        public long KSum(int[] nums, int k)
        {
            Array.Sort(nums, (a, b) => Math.Abs(a).CompareTo(Math.Abs(b)));

            var result = 0L;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] <= 0) continue;
                result += nums[i];
            }

            var queue = new PriorityQueue<(int id, long sum), long>(Comparer<long>.Create((a, b) => b.CompareTo(a)));
            var next = result - Math.Abs(nums[0]);
            queue.Enqueue((0, next), next);

            while (--k > 0)
            {
                var (i, sum) = queue.Dequeue();
                if (i + 1 < nums.Length)
                {
                    var newSum = sum - Math.Abs(nums[i + 1]);
                    queue.Enqueue((i + 1, newSum), newSum);
                    newSum += Math.Abs(nums[i]);
                    queue.Enqueue((i + 1, newSum), newSum);
                }

                result = sum;
            }

            return result;
        }
    }
}
