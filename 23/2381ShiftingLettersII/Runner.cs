namespace LeetCodeTasks._2381ShiftingLettersII
{
    public class Runner
    {
        public void Run()
        {
            var s = "abc";
            var shifts = new int[][]
            {
                new int[] { 0,1,0 },
                new int[] { 1,2,1 },
                new int[] { 0,2,1 },
            };//ace

            /*
            var s = "dztz";
            var shifts = new int[][]
            {
                new int[] { 0,0,0 },
                new int[] { 1,1,1 },
            };//catz
            */
            var cl = new ShiftingLettersII();
            var result = cl.ShiftingLetters(s, shifts);
            Console.WriteLine(result);
        }
    }
}
