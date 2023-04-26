namespace LeetCodeTasks._261GraphValidTree
{
    //premium
    public class GraphValidTree
    {
        private class Dsu
        {
            private Dictionary<int, int> _dsu = new();

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
                _dsu[Find(x)] = Find(y);
            }
        }

        public bool ValidTree(int n, int[][] edges)
        {
            var dsu = new Dsu();
            foreach (var edge in edges)
            {
                if (dsu.Find(edge[0]) == dsu.Find(edge[1])) return false;

                dsu.Union(edge[0], edge[1]);
            }

            var parent = dsu.Find(0);
            for (var i = 1; i < n; i++)
            {
                if (dsu.Find(i) != parent) return false;
            }

            return true;
        }
    }
}
