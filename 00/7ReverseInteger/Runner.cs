namespace LeetCodeTasks._7ReverseInteger
{
    public class Runner
    {
        public void Run()
        {
            //var x = 123;//321
            //var x = -123;//-321
            var x = 120;//21
            var cl = new ReverseInteger();
            var result = cl.Reverse(x);
            Console.WriteLine(result);
        }
    }
}
