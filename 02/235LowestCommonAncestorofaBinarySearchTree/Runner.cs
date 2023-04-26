using LeetCodeTasks.Utility;

namespace LeetCodeTasks._235LowestCommonAncestorofaBinarySearchTree
{
    public class Runner
    {
        public void Run()
        {
            /*
            var root = TreeUtility.BuildBinaryTree(new int?[] { 6, 2, 8, 0, 4, 7, 9, null, null, 3, 5 }); 
            var p = root.left; var q = root.right;//6
            */
            /*
            var root = TreeUtility.BuildBinaryTree(new int?[] { 6, 2, 8, 0, 4, 7, 9, null, null, 3, 5 }); 
            var p = root.left; var q = root.left.right;//2
            */

            var root = TreeUtility.BuildBinaryTree(new int?[] { 2, 1 }); 
            var p = root; var q = root.left;//2
            
            var cl = new LowestCommonAncestorofaBinarySearchTree();
            var result = cl.LowestCommonAncestor(root, p, q);
            Console.WriteLine(result.val);
        }
    }
}
