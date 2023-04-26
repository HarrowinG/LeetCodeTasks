using LeetCodeTasks.Utility;

namespace LeetCodeTasks._230KthSmallestElementinaBST
{
    public class Runner
    {
        public void Run()
        {
            //var nums = "[3,1,4,null,2]"; var k = 1;//1
            var nums = "[5,3,6,2,4,null,null,1]"; var k = 3;//3
            var root = TreeUtility.BuildBinaryTree(InputUtility.StringToNullIntArray(nums));
            var cl = new KthSmallestElementinaBST();
            var result = cl.KthSmallest(root, k);
            Console.WriteLine(result);
        }
    }
}
