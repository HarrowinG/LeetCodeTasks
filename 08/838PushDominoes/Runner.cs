namespace LeetCodeTasks._838PushDominoes
{
    public class Runner
    {
        public void Run()
        {
            //var dominoes = "RR.L";//RR.L
            var dominoes = ".L.R...LR..L..";//LL.RR.LLRRLL..
            var cl = new PushDominoesClass();
            var result = cl.PushDominoes(dominoes);
            Console.WriteLine(result);
        }
    }
}
