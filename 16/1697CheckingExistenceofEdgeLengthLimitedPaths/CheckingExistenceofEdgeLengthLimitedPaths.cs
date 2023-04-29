namespace LeetCodeTasks._1697CheckingExistenceofEdgeLengthLimitedPaths
{
    public class CheckingExistenceofEdgeLengthLimitedPaths
    {
        private class Dsu
        {
            private readonly Dictionary<int, int> _dsu = new();
            private readonly Dictionary<int, int> _rank = new();

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
                if (parentX == parentY) return;

                var rankX = _rank.GetValueOrDefault(parentX, 1);
                var rankY = _rank.GetValueOrDefault(parentY, 1);

                if (rankX < rankY)
                {
                    _rank[parentY] = rankX + rankY;
                    _dsu[parentX] = parentY;
                }
                else
                {
                    _rank[parentX] = rankX + rankY;
                    _dsu[parentY] = parentX;
                }
            }
        }

        public bool[] DistanceLimitedPathsExist(int n, int[][] edgeList, int[][] queries)
        {
            Array.Sort(edgeList, Comparer<int[]>.Create((a, b) => a[2].CompareTo(b[2])));
            var queriesList = new List<int>[queries.Length];
            for (var i = 0; i < queries.Length; i++)
            {
                queriesList[i] = queries[i].ToList();
                queriesList[i].Add(i);
            }

            Array.Sort(queriesList, Comparer<List<int>>.Create((a, b) => a[2].CompareTo(b[2])));

            var result = new bool[queriesList.Length];
            var edgeId = 0;
            var dsu = new Dsu();
            foreach (var query in queriesList)
            {
                var limit = query[2];
                while (edgeId < edgeList.Length && edgeList[edgeId][2] < limit) 
                {
                    dsu.Union(edgeList[edgeId][0], edgeList[edgeId][1]);
                    edgeId++;
                }

                result[query[3]] = dsu.Find(query[0]) == dsu.Find(query[1]);
            }

            return result;
        }
    }
}
