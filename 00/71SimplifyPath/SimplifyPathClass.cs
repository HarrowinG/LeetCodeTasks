using System.Text;

namespace LeetCodeTasks._71SimplifyPath
{
    public class SimplifyPathClass
    {
        public string SimplifyPath(string path)
        {
            var stack = new Stack<string>();
            foreach (var segment in path.Split('/'))
            {
                if (segment == "" || segment == ".") continue;
                if (segment == "..")
                    if (stack.Count > 0) { stack.Pop(); continue; }
                    else continue;
                stack.Push(segment);
            }

            if (stack.Count == 0) return "/";

            var sb = new StringBuilder();
            var arr = stack.ToArray();
            for (var i = arr.Length - 1; i >= 0; i--)
                sb.Append('/').Append(arr[i]);

            return sb.ToString();
        }
    }
}
