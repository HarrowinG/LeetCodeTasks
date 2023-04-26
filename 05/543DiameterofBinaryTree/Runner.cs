using LeetCodeTasks.Utility;

namespace LeetCodeTasks._543DiameterofBinaryTree
{
    public class Runner
    {
        public void Run()
        {
            //var nums = new int?[] { 1, 2, 3, 4, 5 };//3
            var nums = new int?[] { 1, 2 };//1
            var root = TreeUtility.BuildBinaryTree(nums);
            var cl = new DiameterofBinaryTree();
            var result = cl.DiameterOfBinaryTree(root);
            Console.WriteLine(result);
        }
    }
}
