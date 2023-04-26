namespace LeetCodeTasks._1046LastStoneWeight
{
    public class LastStoneWeightClass
    {
        public int LastStoneWeight(int[] stones)
        {
            var queue = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
            foreach (var stone in stones)
                queue.Enqueue(stone, stone);

            while (queue.Count > 1)
            {
                var first = queue.Dequeue();
                var second = queue.Dequeue();
                if (first == second) continue;

                var delta = first - second;
                queue.Enqueue(delta, delta);
            }

            return queue.Count == 0 ? 0 : queue.Dequeue();
        }
    }
}
