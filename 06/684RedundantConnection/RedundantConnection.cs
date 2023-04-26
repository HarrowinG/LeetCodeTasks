namespace LeetCodeTasks._684RedundantConnection
{
    public class RedundantConnection
    {
        private class Dsu
        {
            private Dictionary<int, int> _dsu = new();
            private Dictionary<int, int> _rank = new();

            public int Find(int x)
            {
                var y = _dsu.GetValueOrDefault(x, x);
                if (y != x)
                {
                    y = Find(y);
                    _dsu[x] = y;
                }

                return y;
            }

            public void Union(int x, int y)
            {
                var parentX = Find(x);
                var parentY = Find(y);
                var rankX = 0;
                var rankY = 0;
                if (_rank.ContainsKey(parentX)) rankX = _rank[parentX];
                if (_rank.ContainsKey(parentY)) rankY = _rank[parentY];
                if (rankX > rankY)
                {
                    _dsu[parentY] = parentX;
                    _rank[parentX] = rankX + rankY;
                    _rank.Remove(parentY);
                }
                else
                {
                    _dsu[parentX] = parentY;
                    _rank[parentY] = rankX + rankY;
                    _rank.Remove(parentX);
                }
            }
        }

        public int[] FindRedundantConnection(int[][] edges)
        {
            var result = new int[2];
            var dsu = new Dsu();
            foreach (var edge in edges)
            {
                if (dsu.Find(edge[0]) == dsu.Find(edge[1]))
                {
                    result = edge;
                    continue;
                }

                dsu.Union(edge[0], edge[1]);
            }

            return result;
        }
    }
}
