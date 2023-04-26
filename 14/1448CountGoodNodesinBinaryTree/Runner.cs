using LeetCodeTasks.Utility;

namespace LeetCodeTasks._1448CountGoodNodesinBinaryTree
{
    public class Runner
    {
        public void Run()
        {
            //var nums = "[3,1,4,3,null,1,5]";//4
            //var nums = "[3,3,null,4,2]";//3
            var nums = "[1]";//1
            var root = TreeUtility.BuildBinaryTree(InputUtility.StringToNullIntArray(nums));
            var cl = new CountGoodNodesinBinaryTree();
            var result = cl.GoodNodes(root);
            Console.WriteLine(result);
        }
    }
}
