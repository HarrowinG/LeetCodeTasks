namespace LeetCodeTasks._191Numberof1Bits
{
    public class Runner
    {
        public void Run()
        {
            //var n = 0b00000000000000000000000000001011u;//3
            //uint n = 0b00000000000000000000000010000000;//1
            var n = 0b11111111111111111111111111111101u;//31
            var cl = new Numberof1Bits();
            var result = cl.HammingWeight(n);
            Console.WriteLine(result);
        }
    }
}
