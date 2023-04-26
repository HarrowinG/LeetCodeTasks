namespace LeetCodeTasks._823BinaryTreesWithFactors
{
    public class Runner
    {
        public void Run()
        {
            //var arr = new int[] { 2, 4 }; //3
            //var arr = new int[] { 2, 4, 5, 10 }; //7
            var arr = new int[] { 3,2,18,6 }; //12
            var cl = new BinaryTreesWithFactors();
            var result = cl.NumFactoredBinaryTrees(arr);
            Console.WriteLine(result);
        }
    }
}
