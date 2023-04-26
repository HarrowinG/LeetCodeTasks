using System.Collections.Generic;

namespace LeetCodeTasks._621TaskScheduler
{
    public class TaskScheduler
    {
        public int LeastInterval(char[] tasks, int n)
        {
            //return Heap(tasks, n);
            return Greedy(tasks, n);
        }

        public int Greedy(char[] tasks, int n)
        {
            var counter = new int[26];
            var max = 0;
            var maxCount = 0;
            foreach (var task in tasks)
            {
                var id = task - 'A';
                counter[id]++;
                if (max == counter[id])
                {
                    maxCount++;
                }
                else if (max < counter[id])
                {
                    max = counter[id];
                    maxCount = 1;
                }
            }

            var partCount = max - 1;
            var partLength = n - (maxCount - 1);
            var emptySlots = partCount * partLength;
            var availableTasks = tasks.Length - max * maxCount;
            var idles = Math.Max(0, emptySlots - availableTasks);

            return tasks.Length + idles;
        }

        public int Heap(char[] tasks, int n)
        {
            var time = 0;
            var count = new Dictionary<char, int>();
            foreach (var task in tasks)
                count[task] = count.GetValueOrDefault(task, 0) + 1;

            var pq = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
            foreach (var key in count.Keys)
                pq.Enqueue(count[key], count[key]);

            var queue = new Queue<(int Val, int Time)>();
            while (pq.Count > 0 || queue.Count > 0)
            {
                time++;
                var task = 0;
                if (pq.Count > 0)
                    task = pq.Dequeue();

                task--;

                if (task > 0)
                    queue.Enqueue((task, time + n));

                if (queue.Count > 0 && queue.Peek().Time == time)
                {
                    var item = queue.Dequeue();
                    pq.Enqueue(item.Val, item.Val);
                }
            }

            return time;
        }
    }
}
