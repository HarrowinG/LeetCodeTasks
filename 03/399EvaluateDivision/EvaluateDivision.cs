namespace LeetCodeTasks._399EvaluateDivision
{
    public class EvaluateDivision
    {
        readonly HashSet<string> _seen = new();
        readonly Dictionary<string, string> _parents = new();
        readonly Dictionary<string, double> _vals = new();
        readonly Dictionary<string, Dictionary<string, double>> _edges = new();

        public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries)
        {
            for (var i = 0; i < equations.Count; i++)
            {
                var start = equations[i][0]; var end = equations[i][1];
                _edges[start] = _edges.GetValueOrDefault(start, new Dictionary<string, double>());
                _edges[start][end] = values[i];
                _edges[end] = _edges.GetValueOrDefault(end, new Dictionary<string, double>());
                _edges[end][start] = 1 / values[i];
            }

            foreach (var start in _edges.Keys)
                if (!_seen.Contains(start))
                    Dfs(start, start, 1);

            var result = new double[queries.Count];
            for (var i = 0; i < queries.Count; i++)
            {
                var start = queries[i][0]; var end = queries[i][1];
                var parentStart = _parents.GetValueOrDefault(start, start);
                var parentEnd = _parents.GetValueOrDefault(end, end);

                if (!_vals.ContainsKey(start) || !_vals.ContainsKey(end) || parentStart != parentEnd) 
                    result[i] = -1;
                else result[i] = _vals[start] / _vals[end];
            }
            return result;
        }

        private void Dfs(string current, string parent, double value)
        {
            _vals[current] = value;
            _parents[current] = parent;
            _seen.Add(current);
            foreach (var next in _edges[current].Keys)
            {
                if (!_seen.Contains(next))
                    Dfs(next, parent, value * _edges[next][current]);
            }
        }
    }
}
