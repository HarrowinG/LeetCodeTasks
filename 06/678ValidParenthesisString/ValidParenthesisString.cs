namespace LeetCodeTasks._678ValidParenthesisString
{
    public class ValidParenthesisString
    {
        public bool CheckValidString(string s)
        {
            var leftMin = 0;
            var leftMax = 0;
            foreach (var c in s)
            {
                if (c == '(')
                {
                    leftMin++;
                    leftMax++;
                }
                else if (c == ')')
                {
                    leftMin--;
                    leftMax--;
                }
                else
                {
                    leftMin--;
                    leftMax++;
                }

                if (leftMax < 0) return false;
                if (leftMin < 0) leftMin = 0;
            }

            return leftMin == 0;
        }
    }
}
