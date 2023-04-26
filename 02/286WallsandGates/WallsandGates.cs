namespace LeetCodeTasks._286WallsandGates
{
    //premium
    public class WallsandGates
    {
        public void WallsAndGates(int[][] rooms)
        {
            var queue = new Queue<(int r, int c)>();
            for (int i = 0; i < rooms.Length; i++)
                for (int j = 0; j < rooms[i].Length; j++)
                    if (rooms[i][j] == 0) queue.Enqueue((i, j));

            var step = 1;
            while (queue.Count > 0)
            {
                var n = queue.Count;
                for (int i = 0; i < n; i++)
                {
                    var (r, c) = queue.Dequeue();
                    AddRoom(r + 1, c);
                    AddRoom(r - 1, c);
                    AddRoom(r, c + 1);
                    AddRoom(r, c - 1);
                }

                step++;
            }

            void AddRoom(int r, int c)
            {
                if (r < 0 || r >= rooms.Length || c < 0 || c >= rooms[0].Length 
                    || rooms[r][c] == -1 || rooms[r][c] != int.MaxValue) return;

                rooms[r][c] = step;
                queue.Enqueue((r, c));
            }
        }
    }
}
