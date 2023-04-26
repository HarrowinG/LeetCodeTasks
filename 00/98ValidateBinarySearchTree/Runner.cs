using LeetCodeTasks.Utility;

namespace LeetCodeTasks._98ValidateBinarySearchTree
{
    public class Runner
    {
        public void Run()
        {
            //var arr = new int?[] { 2, 1, 3 };//true
            //var arr = new int?[] { 5, 1, 4, null, null, 3, 6 };//false
            //var arr = new int?[] { 5, 4, 6, null, null, 3, 7 };//false
            var arr = new int?[] { 2147483647 };//true
            var root = TreeUtility.BuildBinaryTree(arr);
            var cl = new ValidateBinarySearchTree();
            var result = cl.IsValidBST(root);
            Console.WriteLine(result);
        }
    }
}
