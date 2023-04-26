using LeetCodeTasks.Utility;

namespace LeetCodeTasks._105ConstructBinaryTreefromPreorderandInorderTraversal
{
    public class Runner
    {
        public void Run()
        {
            var strPreorder = "[3,9,20,15,7]"; var strInorder = "[9,3,15,20,7]";//[3,9,20,null,null,15,7]
            //var strPreorder = "[-1]"; var strInorder = "[-1]";//[-1]
            //var strPreorder = "[1,2,4,7,8,9,5,3,6]"; var strInorder = "[8,7,9,4,2,5,1,3,6]";//[1,2,3,4,5,null,6,7,null,n,n,n,n,8,9]
            var preorder = InputUtility.StringToIntArray(strPreorder);
            var inorder = InputUtility.StringToIntArray(strInorder);
            var cl = new ConstructBinaryTreefromPreorderandInorderTraversal();
            var result = cl.BuildTree(preorder, inorder);
            Console.WriteLine(ResultUtility.BinaryTree(result));
        }
    }
}
