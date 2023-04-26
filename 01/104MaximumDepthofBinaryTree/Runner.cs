using LeetCodeTasks.Utility;

namespace LeetCodeTasks._104MaximumDepthofBinaryTree
{
    public class Runner
    {
        public void Run()
        {
            var nums = new int?[] { 3, 9, 20, null, null, 15, 7 };//3
            //var nums = new int?[] { 1, null, 2 };//2
            var root = TreeUtility.BuildBinaryTree(nums);
            var cl = new MaximumDepthofBinaryTree();
            var result = cl.MaxDepth(root);
            Console.WriteLine(result);
        }
    }
}
