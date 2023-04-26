namespace LeetCodeTasks._20ValidParentheses
{
    public class ValidParentheses
    {
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();
            var openBraces = new HashSet<char> { '{', '[', '(' };
            foreach (var c in s)
            {
                if (openBraces.Contains(c))
                {
                    stack.Push(c);
                    continue;
                }

                if (stack.Count == 0) return false;
                if (stack.Pop() != GetOpenBrace(c)) return false;
            }

            return stack.Count == 0;
        }

        private char GetOpenBrace(char closingBrace)
        {
            return closingBrace switch
            {
                ')' => '(',
                ']' => '[',
                '}' => '{',
                _ => '*',
            };
        }
    }
}
