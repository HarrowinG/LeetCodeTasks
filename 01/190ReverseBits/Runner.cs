namespace LeetCodeTasks._190ReverseBits
{
    public class Runner
    {
        public void Run()
        {
            //var n = 0b00000010100101000001111010011100u;//964176192 (00111001011110000010100101000000)
            var n = 0b11111111111111111111111111111101u;//3221225471 (10111111111111111111111111111111)
            var cl = new ReverseBitsClass();
            var result = cl.reverseBits(n);
            Console.WriteLine($"{result}: {Convert.ToString(result, 2)}");
        }
    }
}
