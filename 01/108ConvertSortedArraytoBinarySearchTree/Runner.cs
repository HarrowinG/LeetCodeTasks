namespace LeetCodeTasks._108ConvertSortedArraytoBinarySearchTree
{
    public class Runner
    {
        public void Run()
        {
            //var nums = new int[] { -10, -3, 0, 5, 9 };//0,-3,9,-10,null,5 or 0,-10,5,null,-3,null,9
            var nums = new int[] { 1, 3 };//3,1 or 1,null,3
            var cl = new ConvertSortedArraytoBinarySearchTree();
            var result = cl.SortedArrayToBST(nums);
            Console.ReadLine();
        }
    }
}
