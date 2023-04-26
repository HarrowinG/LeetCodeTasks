namespace LeetCodeTasks._946ValidateStackSequences
{
    public class ValidateStackSequencesClass
    {
        public bool ValidateStackSequences(int[] pushed, int[] popped)
        {
            //return WithStack(pushed, popped);
            return PushedAsStack(pushed, popped);
        }

        private bool PushedAsStack(int[] pushed, int[] popped)
        {
            var i = 0; var j = 0;
            foreach (var item in pushed)
            {
                pushed[i++] = item;
                while (i > 0 && pushed[i - 1] == popped[j])
                {
                    i--;
                    j++;
                }
            }

            return i == 0;
        }

        private bool WithStack(int[] pushed, int[] popped)
        {
            var j = 0;
            var stack = new Stack<int>();
            foreach (var item in pushed)
            {
                stack.Push(item);
                while (stack.Count > 0 && stack.Peek() == popped[j])
                {
                    stack.Pop();
                    j++;
                }
            }

            return stack.Count == 0;
        }
    }
}
