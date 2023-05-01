using LeetCodeTasks.Utility;

namespace LeetCodeTasks._1491AverageSalaryExcludingtheMinimumandMaximumSalary
{
    public class Runner
    {
        public void Run()
        {
            var cl = new AverageSalaryExcludingtheMinimumandMaximumSalary();
            var strSalary = "[4000,3000,1000,2000]";//2500.00000
            //var strSalary = "[1000,2000,3000]";//2000.00000
            var salary = InputUtility.StringToIntArray(strSalary);
            var result = cl.Average(salary);
            Console.WriteLine(result);
        }
    }
}
