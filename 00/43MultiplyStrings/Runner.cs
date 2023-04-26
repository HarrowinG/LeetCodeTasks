namespace LeetCodeTasks._43MultiplyStrings
{
    public class Runner
    {
        public void Run()
        {
            //var num1 = "2"; var num2 = "3";//6
            var num1 = "123"; var num2 = "456";//56088
            var cl = new MultiplyStrings();
            var result = cl.Multiply(num1, num2);
            Console.WriteLine(result);
        }
    }
}
