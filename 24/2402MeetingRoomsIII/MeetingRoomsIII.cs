namespace LeetCodeTasks._2402MeetingRoomsIII
{
    public class MeetingRoomsIII
    {
        public int MostBooked(int n, int[][] meetings)
        {
            var roomVisists = new int[n];
            Array.Sort(meetings, (a, b) => a[0].CompareTo(b[0]));
            var available = new PriorityQueue<int, int>();
            for (int i = 0; i < n; i++) available.Enqueue(i, i);

            var queue = new PriorityQueue<(long end, int room), (long end, int room)>(
                Comparer<(long end, int room)>.Create((a, b) => a.end == b.end ? a.room.CompareTo(b.room) : a.end.CompareTo(b.end)));
            foreach (var meet in meetings)
            {
                while (queue.Count > 0 && queue.Peek().end <= meet[0])
                {
                    var ended = queue.Dequeue();
                    available.Enqueue(ended.room, ended.room);
                }

                long duration = meet[1] - meet[0];
                long start = available.Count == 0 ? queue.Peek().end : meet[0];
                var room = available.Count == 0 ? queue.Peek().room : available.Peek();
                
                if (available.Count == 0) queue.Dequeue();
                else available.Dequeue();

                roomVisists[room]++;
                var item = (start + duration, room);
                queue.Enqueue(item, item);
            }

            var id = 0;
            for (int i = 1; i < n; i++)
            {
                if (roomVisists[i] > roomVisists[id])
                {
                    id = i;
                }
            }

            return id;
        }
    }
}
