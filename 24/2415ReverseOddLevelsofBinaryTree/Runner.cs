using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2415ReverseOddLevelsofBinaryTree
{
    public class Runner
    {
        public void Run()
        {
            //var strRoot = "[2,3,5,8,13,21,34]";//[2,5,3,8,13,21,34]
            //var strRoot = "[7,13,11]";//[7,11,13]
            var strRoot = "[0,1,2,0,0,0,0,1,1,1,1,2,2,2,2]";//[0,2,1,0,0,0,0,2,2,2,2,1,1,1,1]
            var root = TreeUtility.BuildBinaryTree(InputUtility.StringToNullIntArray(strRoot));
            var cl = new ReverseOddLevelsofBinaryTree();
            var result = cl.ReverseOddLevels(root);
            var a = 0;
        }
    }
}
