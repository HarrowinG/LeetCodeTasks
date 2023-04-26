namespace LeetCodeTasks._130SurroundedRegions
{
    public class SurroundedRegions
    {
        public void Solve(char[][] board)
        {
            var verified = new bool[board.Length, board[0].Length];
            for (int i = 0; i < board[0].Length; i++) Bfs(board, verified, 0, i);
            for (int i = 0; i < board.Length; i++) Bfs(board, verified, i, board[0].Length - 1);
            for (int i = 0; i < board[0].Length; i++) Bfs(board, verified, board.Length - 1, i);
            for (int i = 0; i < board.Length; i++) Bfs(board, verified, i, 0);

            for (int i = 0; i < board.Length; i++)
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] == 'O') board[i][j] = 'X';
                    else if (board[i][j] == 'T') board[i][j] = 'O';
                }
        }

        private void Bfs(char[][] board, bool[,] verified, int x, int y)
        {
            if (board[x][y] == 'X' || verified[x, y]) return;
            var queue = new Queue<(int x, int y)>();
            queue.Enqueue((x, y));
            verified[x, y] = true;
            while (queue.Count > 0)
            {
                var item = queue.Dequeue();
                board[item.x][item.y] = 'T';

                foreach (var neighbor in GetNeighbors(board, item.x, item.y))
                {
                    if (board[neighbor.x][neighbor.y] == 'X' || verified[neighbor.x, neighbor.y]) continue;

                    queue.Enqueue(neighbor);
                    verified[neighbor.x, neighbor.y] = true;
                }
            }
        }

        private static readonly int[] _rowDeltas = { 0, 1, 0, -1 };
        private static readonly int[] _colDeltas = { 1, 0, -1, 0 };
        private IEnumerable<(int x, int y)> GetNeighbors(char[][] board, int x, int y)
        {
            for (int i = 0; i < _rowDeltas.Length; i++)
            {
                var r = _rowDeltas[i] + x;
                var c = _colDeltas[i] + y;
                if (r < 0 || r >= board.Length || c < 0 || c >= board[0].Length) continue;

                yield return (r, c);
            }
        }
    }
}
