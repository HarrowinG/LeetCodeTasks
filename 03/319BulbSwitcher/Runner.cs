namespace LeetCodeTasks._319BulbSwitcher
{
    public class Runner
    {
        public void Run()
        {
            var cl = new BulbSwitcher();
            //var n = 3;//1
            //var n = 0;//0
            var n = 1;//1
            var result = cl.BulbSwitch(n);
            Console.WriteLine(result);
        }
    }
}
