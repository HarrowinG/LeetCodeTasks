namespace LeetCodeTasks._7ReverseInteger
{
    public class ReverseInteger
    {
        public int Reverse(int x)
        {
            //return StringReverse(x);
            return ReverseByDigit(x);
        }

        private int ReverseByDigit(int x)
        {
            int result = 0;
            while (x != 0)
            {
                int tail = x % 10;
                int newResult = result * 10 + tail;
                if ((newResult - tail) / 10 != result)
                    return 0;
                result = newResult;
                x /= 10;
            }

            return result;
        }

        private int StringReverse(int x)
        {
            var lessThanZero = x < 0;
            var strX = x.ToString().Trim('-');
            var reversedSequence = strX.Reverse();
            string reversedStr;
            if (lessThanZero)
            {
                reversedStr = "-" + new string(reversedSequence.ToArray());
            }
            else
            {
                reversedStr = new string(reversedSequence.ToArray());
            }

            try
            {
                var reversedX = int.Parse(reversedStr);
                return reversedX;
            }
            catch (OverflowException)
            {
                return 0;
            }
        }
    }
}
