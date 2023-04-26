namespace LeetCodeTasks._412FizzBuzz
{
    public class FizzBuzzClass
    {
        public IList<string> FizzBuzz(int n)
        {
            var dividedBy3 = 3;
            var dividedBy5 = 5;
            var result = new List<string>();
            for (var i = 1; i <= n; i++)
            {
                if (i == dividedBy3 && i == dividedBy5)
                {
                    result.Add("FizzBuzz");
                    dividedBy5 += 5;
                    dividedBy3 += 3;
                }
                else if (i == dividedBy3)
                {
                    result.Add("Fizz");
                    dividedBy3 += 3;
                }
                else if (i == dividedBy5)
                {
                    result.Add("Buzz");
                    dividedBy5 += 5;
                }
                else result.Add(i.ToString());
            }

            return result;
        }
    }
}
