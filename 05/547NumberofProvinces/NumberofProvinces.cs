namespace LeetCodeTasks._547NumberofProvinces
{
    public class NumberofProvinces
    {
        private class Dsu
        {
            readonly Dictionary<int, int> _set = new();

            public int Find(int x)
            {
                var y = _set.GetValueOrDefault(x, x);
                if (y != x)
                {
                    y = Find(y);
                    _set[x] = y;
                }

                return y;
            }

            public void Union(int x, int y)
            {
                _set[Find(y)] = Find(x);
            }
        }

        public int FindCircleNum(int[][] isConnected)
        {
            var result = isConnected.Length;
            var dsu = new Dsu();
            for (var i =  0; i < isConnected.Length; i++)
                for (var j = i + 1; j < isConnected[i].Length; j++)
                    if (isConnected[i][j] == 1 && dsu.Find(i) != dsu.Find(j))
                    {
                        dsu.Union(i, j);
                        result--;
                    }

            return result;
        }
    }
}
