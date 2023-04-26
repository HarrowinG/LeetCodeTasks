namespace LeetCodeTasks._2396StrictlyPalindromicNumber
{
    public class StrictlyPalindromicNumber
    {
        //answer is always false for any n, can be just returned false)))
        public bool IsStrictlyPalindromic(int n)
        {
            for (int i = 2; i < n - 1; i++)
            {
                var temp = n;
                var list = new List<int>();
                while (temp > 0)
                {
                    var digit = temp % i;
                    list.Add(digit);
                    temp /= i;
                }

                if (!Check(list)) return false;
            }

            return true;
        }

        private bool Check(List<int> s)
        {
            var l = 0;
            var r = s.Count - 1;
            while (l < r)
            {
                if (s[l] != s[r]) return false;
                l++;
                r--;
            }

            return true;
        }
    }
}
