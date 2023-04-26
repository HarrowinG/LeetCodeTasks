namespace LeetCodeTasks._2013DetectSquares
{
    public class DetectSquares
    {
        private readonly Dictionary<int, Dictionary<int, int>> _x = new();

        public DetectSquares() { }

        public void Add(int[] point)
        {
            var x = point[0];
            var y = point[1];
            _x[x] = _x.GetValueOrDefault(x, new Dictionary<int, int>());
            _x[x][y] = _x[x].GetValueOrDefault(y, 0) + 1;
        }

        public int Count(int[] point)
        {
            var targetX = point[0];
            var targetY = point[1];
            if (!_x.ContainsKey(targetX)) return 0;

            var count = 0;
            foreach (var kvp in _x[targetX])
            {
                var y = kvp.Key;
                if (y == targetY) continue;
                var delta = Math.Abs(y - targetY);

                count += CountSquares(targetX + delta, y);
                count += CountSquares(targetX - delta, y);
            }

            return count;

            int CountSquares(int x, int y)
            {
                if (_x.ContainsKey(x))
                {
                    var ys = _x[x];
                    if (ys.ContainsKey(targetY) && ys.ContainsKey(y))
                        return _x[targetX][y] * _x[x][targetY] * _x[x][y];
                }

                return 0;
            }
        }
    }
}
