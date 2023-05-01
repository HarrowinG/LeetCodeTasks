namespace LeetCodeTasks._1491AverageSalaryExcludingtheMinimumandMaximumSalary
{
    public class AverageSalaryExcludingtheMinimumandMaximumSalary
    {
        public double Average(int[] salary)
        {
            var sum = 0;
            var min = int.MaxValue; var max = int.MinValue;
            for (var i = 0; i < salary.Length; i++)
            {
                if (salary[i] < min)
                    min = salary[i];
                if (salary[i] > max)
                    max = salary[i];

                sum += salary[i];
            }

            return (sum - min - max) / (salary.Length - 2d);
        }
    }
}
