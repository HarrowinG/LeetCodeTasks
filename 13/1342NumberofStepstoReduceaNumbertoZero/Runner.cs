namespace LeetCodeTasks._1342NumberofStepstoReduceaNumbertoZero
{
    public class Runner
    {
        public void Run()
        {
            var cl = new NumberofStepstoReduceaNumbertoZero();
            var num = 14;//6
            //var num = 8;//4
            //var num = 123;//12
            //var num = 0;//0
            var result = cl.NumberOfSteps(num);
            Console.WriteLine(result);
        }
    }
}
