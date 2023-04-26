using LeetCodeTasks.Utility;

namespace LeetCodeTasks._100SameTree
{
    public class Runner
    {
        public void Run()
        {
            //var nums1 = new int?[] { 1, 2, 3 }; var nums2 = new int?[] { 1, 2, 3 };//true
            //var nums1 = new int?[] { 1, 2 }; var nums2 = new int?[] { 1, null, 2 };//false
            var nums1 = new int?[] { 1, 2, 1 }; var nums2 = new int?[] { 1, 1, 2 };//false
            var p = TreeUtility.BuildBinaryTree(nums1);
            var q = TreeUtility.BuildBinaryTree(nums2);
            var cl = new SameTree();
            var result = cl.IsSameTree(p, q);
            Console.WriteLine(result);
        }
    }
}
