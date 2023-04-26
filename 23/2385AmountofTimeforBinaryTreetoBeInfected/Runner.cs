using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2385AmountofTimeforBinaryTreetoBeInfected
{
    public class Runner
    {
        public void Run()
        {
            //var nums = new int?[] { 1, 5, 3, null, 4, 10, 6, 9, 2 }; var start = 3;//4
            var nums = new int?[] { 1 }; var start = 1;//0
            var root = TreeUtility.BuildBinaryTree(nums);
            var cl = new AmountofTimeforBinaryTreetoBeInfected();
            var result = cl.AmountOfTime(root, start);
            Console.WriteLine(result);
        }
    }
}
