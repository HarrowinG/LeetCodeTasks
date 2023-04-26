using LeetCodeTasks.Utility;

namespace LeetCodeTasks._662MaximumWidthofBinaryTree
{
    public class Runner
    {
        public void Run()
        {
            var cl = new MaximumWidthofBinaryTree();
            //var strRoot = "[1,3,2,5,3,null,9]";//4
            //var strRoot = "[1,3,2,5,null,null,9,6,null,7]";//7
            //var strRoot = "[1,3,2,5,null,null,9,6,null,7]";//7
            var strRoot = "[1,3,2,5]";//2
            var root = TreeUtility.BuildBinaryTree(InputUtility.StringToNullIntArray(strRoot));
            var result = cl.WidthOfBinaryTree(root);
            Console.WriteLine(result);
        }
    }
}
