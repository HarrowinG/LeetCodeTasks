namespace LeetCodeTasks._155MinStack
{
    public class MinStack
    {
        private Stack<int> _stack = new();
        private Stack<int> _min = new();

        public MinStack() { }

        public void Push(int val)
        {
            var min = val;
            if (_stack.Count > 0)
            {
                min = Math.Min(val, _min.Peek());
            }

            _stack.Push(val);
            _min.Push(min);
        }

        public void Pop()
        {
            _stack.Pop();
            _min.Pop();
        }

        public int Top()
        {
            return _stack.Peek();
        }

        public int GetMin()
        {
            return _min.Peek();
        }
    }
}
