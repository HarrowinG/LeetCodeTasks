using LeetCodeTasks.Utility;

namespace LeetCodeTasks._530MinimumAbsoluteDifferenceinBST
{
    public class Runner
    {
        public void Run()
        {
            var cl = new MinimumAbsoluteDifferenceinBST();
            //var strRoot = "[4,2,6,1,3]";//1
            //var strRoot = "[1,0,48,null,null,12,49]";//1
            var strRoot = "[236,104,701,null,227,null,911]";//9
            var root = TreeUtility.BuildBinaryTree(InputUtility.StringToNullIntArray(strRoot));
            var result = cl.GetMinimumDifference(root);
            Console.WriteLine(result);
        }
    }
}
