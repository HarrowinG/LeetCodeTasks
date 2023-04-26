namespace LeetCodeTasks._973KClosestPointstoOrigin
{
    public class KClosestPointstoOrigin
    {
        public int[][] KClosest(int[][] points, int k)
        {
            var result = new List<int[]>();
            var queue = new PriorityQueue<(int distance, int[] arr), int>(Comparer<int>.Create((a,b) => b.CompareTo(a)));
            for (int i = 0; i < points.Length; i++)
            {
                var point = points[i];
                var distance = point[0] * point[0] + point[1] * point[1];

                if (queue.Count == k)
                {
                    var item = queue.Peek();
                    if (distance < item.distance)
                    {
                        queue.Enqueue((distance, point), distance);
                        queue.Dequeue();
                    }
                }
                else
                {
                    queue.Enqueue((distance, point), distance);
                }
            }

            while (queue.Count > 0)
            {
                result.Add(queue.Dequeue().arr);
            }

            return result.ToArray();
        }
    }
}
