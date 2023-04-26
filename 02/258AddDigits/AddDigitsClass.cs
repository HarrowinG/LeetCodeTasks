namespace LeetCodeTasks._258AddDigits
{
    public class AddDigitsClass
    {
        public int AddDigits(int num)
        {
            //return Iterative(num);
            return Math(num);
        }

        private int Iterative(int num)
        {
            int sum = 0;
            while (num > 9)
            {
                while (num > 0)
                {
                    sum += (num % 10);
                    num /= 10;
                }
                num = sum;
                sum = 0;
            }
            return num;
        }

        private int Math(int num)
        {
            if (num == 0) return 0;
            if (num % 9 == 0) return 9;
            return num % 9;
        }
    }
}
