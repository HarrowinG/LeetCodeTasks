namespace LeetCodeTasks._150EvaluateReversePolishNotation
{
    public class EvaluateReversePolishNotation
    {
        public int EvalRPN(string[] tokens)
        {
            var stack = new Stack<int>();
            var signs = new HashSet<string> { "+", "-", "*", "/" };

            foreach (var token in tokens)
            {
                if (signs.Contains(token))
                {
                    var second = stack.Pop();
                    stack.Push(Evaluate(stack.Pop(), second, token));
                }
                else
                {
                    stack.Push(int.Parse(token));
                }
            }

            return stack.Pop();
        }

        private int Evaluate(int x, int y, string sign)
        {
            switch (sign)
            {
                case "+":
                    return x + y;
                case "-":
                    return x - y;
                case "*":
                    return x * y;
                default:
                    return x / y;
            }
        }
    }
}
