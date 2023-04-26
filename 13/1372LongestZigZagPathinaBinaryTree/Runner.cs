using LeetCodeTasks.Utility;

namespace LeetCodeTasks._1372LongestZigZagPathinaBinaryTree
{
    public class Runner
    {
        public void Run()
        {
            var cl = new LongestZigZagPathinaBinaryTree();
            var strRoot = "[1,null,1,1,1,null,null,1,1,null,1,null,null,null,1,null,1]";//3
            //var strRoot = "[1,1,1,null,1,null,null,1,1,null,1]";//4
            //var strRoot = "[1]";//0
            var root = TreeUtility.BuildBinaryTree(InputUtility.StringToNullIntArray(strRoot));
            var result = cl.LongestZigZag(root);
            Console.WriteLine(result);
        }
    }
}
