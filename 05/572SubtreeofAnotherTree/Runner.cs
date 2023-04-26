using LeetCodeTasks.Utility;

namespace LeetCodeTasks._572SubtreeofAnotherTree
{
    public class Runner
    {
        public void Run()
        {
            //var nums1 = new int?[] { 3, 4, 5, 1, 2 }; var nums2 = new int?[] { 4, 1, 2 };//true
            //var nums1 = new int?[] { 3, 4, 5, 1, 2, null, null, null, null, 0 }; var nums2 = new int?[] { 4, 1, 2 };//false
            var nums1 = new int?[] { 1, 1 }; var nums2 = new int?[] { 1 };//true
            var root = TreeUtility.BuildBinaryTree(nums1);
            var subRoot = TreeUtility.BuildBinaryTree(nums2);
            var cl = new SubtreeofAnotherTree();
            var result = cl.IsSubtree(root, subRoot);
            Console.WriteLine(result);
        }
    }
}
