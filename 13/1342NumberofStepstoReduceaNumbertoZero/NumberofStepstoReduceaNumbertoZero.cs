namespace LeetCodeTasks._1342NumberofStepstoReduceaNumbertoZero
{
    public class NumberofStepstoReduceaNumbertoZero
    {
        public int NumberOfSteps(int num)
        {
            if (num == 0) return 0;

            var steps = 0;
            while (num > 0)
            {
                steps += 1 + (1 & num);
                num >>= 1;
            }

            return steps - 1;
        }
    }
}
