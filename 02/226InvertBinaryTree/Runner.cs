using LeetCodeTasks.Utility;

namespace LeetCodeTasks._226InvertBinaryTree
{
    public class Runner
    {
        public void Run()
        {
            var nums = new int?[] { 4, 2, 7, 1, 3, 6, 9 };//4,7,2,9,6,3,1
            //var nums = new int?[] { 2, 1, 3 };//2,3,1
            //var nums = new int?[] {  };//
            var root = TreeUtility.BuildBinaryTree(nums);
            var cl = new InvertBinaryTree();
            var result = cl.InvertTree(root);
        }
    }
}
