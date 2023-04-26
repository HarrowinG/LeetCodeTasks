using LeetCodeTasks.Utility;

namespace LeetCodeTasks._110BalancedBinaryTree
{
    public class Runner
    {
        public void Run()
        {
            //var nums = new int?[] { 3, 9, 20, null, null, 15, 7 }; //true
            //var nums = new int?[] { 1, 2, 2, 3, 3, null, null, 4, 4 }; //false
            var nums = new int?[] { }; //true
            var root = TreeUtility.BuildBinaryTree(nums);
            var cl = new BalancedBinaryTree();
            var result = cl.IsBalanced(root);
            Console.WriteLine(result);
        }
    }
}
