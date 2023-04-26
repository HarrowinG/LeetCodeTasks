using System.Text;

namespace LeetCodeTasks._2375ConstructSmallesNumberFromDIString
{
    public class ConstructSmallesNumberFromDIString
    {
        public string SmallestNumber(string pattern)
        {
            var result = new StringBuilder();
            var stack = new Stack<int>();
            for (var i = 0; i <= pattern.Length; i++)
            {
                stack.Push(i + 1);
                if (i == pattern.Length || pattern[i] == 'I')
                {
                    while (stack.Count > 0)
                    {
                        result.Append(stack.Pop());
                    }
                }
            }
            

            return result.ToString();
        }
    }
}
