namespace LeetCodeTasks._739DailyTemperatures
{
    public class DailyTemperaturesClass
    {
        public int[] DailyTemperatures(int[] temperatures)
        {
            var result = new int[temperatures.Length];
            var positions = new Stack<int>();
            for (var i = 0; i < temperatures.Length; i++)
            {
                while (positions.Count > 0 && temperatures[i] > temperatures[positions.Peek()])
                {
                    var pos = positions.Pop();
                    result[pos] = i - pos;
                }

                positions.Push(i);
            }

            return result;
        }

        public int[] DailyTemperatures1(int[] temperatures)
        {
            var result = new int[temperatures.Length];
            var positions = new Stack<int>();
            for (var i = temperatures.Length - 1; i >= 0; i--)
            {
                while (positions.Count > 0 && temperatures[positions.Peek()] <= temperatures[i])
                {
                    positions.Pop();
                }

                if (positions.Count != 0)
                    result[i] = positions.Peek() - i;

                positions.Push(i);
            }

            return result;
        }
    }
}
