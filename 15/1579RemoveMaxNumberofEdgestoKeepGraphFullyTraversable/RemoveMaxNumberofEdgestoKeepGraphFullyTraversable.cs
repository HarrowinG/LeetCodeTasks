namespace LeetCodeTasks._1579RemoveMaxNumberofEdgestoKeepGraphFullyTraversable
{
    public class RemoveMaxNumberofEdgestoKeepGraphFullyTraversable
    {
        private class Dsu
        {
            readonly Dictionary<int, int> _dsu = new();
            readonly Dictionary<int, int> _rank = new();

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

            public bool Union(int x, int y)
            {
                var parentX = Find(x);
                var parentY = Find(y);
                if (parentX == parentY) return false;

                var rankX = _rank.GetValueOrDefault(parentX, 1);
                var rankY = _rank.GetValueOrDefault(parentY, 1);
                if (rankX < rankY)
                {
                    _dsu[parentX] = parentY;
                    _rank[parentY] = rankX + rankY;
                }
                else
                {
                    _dsu[parentY] = parentX;
                    _rank[parentX] = rankX + rankY;
                }

                return true;
            }

            public int Rank(int x)
            {
                var parentX = Find(x);
                return _rank.GetValueOrDefault(parentX, 1);
            }
        }

        public int MaxNumEdgesToRemove(int n, int[][] edges)
        {
            Array.Sort(edges, Comparer<int[]>.Create((a, b) => b[0].CompareTo(a[0])));
            var edgesUsed = 0;
            var alice = new Dsu();
            var bob = new Dsu();

            foreach (var edge in edges)
            {
                var type = edge[0];
                var src = edge[1];
                var dst = edge[2];

                switch (type)
                {
                    case 3:
                        if (alice.Union(src, dst) | bob.Union(src, dst))
                            edgesUsed++;
                        break;
                    case 2:
                        if (bob.Union(src, dst))
                            edgesUsed++;
                        break;
                    default:
                        if (alice.Union(src, dst))
                            edgesUsed++;
                        break;
                }
            }

            return alice.Rank(1) == n && bob.Rank(1) == n 
                ? edges.Length - edgesUsed 
                : -1;
        }
    }
}
