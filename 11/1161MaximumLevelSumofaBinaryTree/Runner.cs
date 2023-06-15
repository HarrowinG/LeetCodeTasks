using LeetCodeTasks.Utility;

namespace LeetCodeTasks._1161MaximumLevelSumofaBinaryTree
{
    public class Runner
    {
        public void Run()
        {
            var cl = new MaximumLevelSumofaBinaryTree();
            //var strRoot = "[1,7,0,7,-8,null,null]";//2
            var strRoot = "[989,null,10250,98693,-89388,null,null,null,-32127]";//2
            var root = TreeUtility.BuildBinaryTree(InputUtility.StringToNullIntArray(strRoot));
            var result = cl.MaxLevelSum(root);
            Console.WriteLine(result);
        }
    }
}
