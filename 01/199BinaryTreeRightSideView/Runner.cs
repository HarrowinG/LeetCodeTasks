using LeetCodeTasks.Utility;

namespace LeetCodeTasks._199BinaryTreeRightSideView
{
    public class Runner
    {
        public void Run()
        {
            //var nums = "[1,2,3,null,5,null,4]";//[1,3,4]
            //var nums = "[1,null,3]";//[1,3]
            var nums = "[]";//[]
            var root = TreeUtility.BuildBinaryTree(InputUtility.StringToNullIntArray(nums));
            var cl = new BinaryTreeRightSideView();
            var result = cl.RightSideView(root);
            Console.WriteLine(ResultUtility.List(result));
        }
    }
}
