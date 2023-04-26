using LeetCodeTasks.Utility;

namespace LeetCodeTasks._102BinaryTreeLevelOrderTraversal
{
    public class Runner
    {
        public void Run()
        {
            //var nums = "[3,9,20,null,null,15,7]";//[[3],[9,20],[15,7]]
            //var nums = "[1]";//[[1]]
            var nums = "[]";//[]
            var root = TreeUtility.BuildBinaryTree(InputUtility.StringToNullIntArray(nums));
            var cl = new BinaryTreeLevelOrderTraversal();
            var result = cl.LevelOrder(root);
            Console.WriteLine(ResultUtility.List2D(result));
        }
    }
}
