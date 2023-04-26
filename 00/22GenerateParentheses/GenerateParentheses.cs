using System.Text;

namespace LeetCodeTasks._22GenerateParentheses
{
    public class GenerateParentheses
    {
        public IList<string> GenerateParenthesis(int n)
        {
            var result = new List<string>();
            var sb = new StringBuilder(2 * n);
            Dfs(n, 0, 0, result, sb);
            return result;
        }

        private void Dfs(int n, int opened, int closed, IList<string> result, StringBuilder current)
        {
            if (current.Length == n * 2)
            {
                result.Add(current.ToString());
                return;
            }

            if (opened < n)
            {
                current.Append("(");
                Dfs(n, opened + 1, closed, result, current);
                current = current.Remove(current.Length - 1, 1);
            }
            if (closed < opened)
            {
                current.Append(")");
                Dfs(n, opened, closed + 1, result, current);
                current = current.Remove(current.Length - 1, 1);
            }
        }
    }
}
