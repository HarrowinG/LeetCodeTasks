using LeetCodeTasks.Utility;

namespace LeetCodeTasks._105ConstructBinaryTreefromPreorderandInorderTraversal
{
    public class ConstructBinaryTreefromPreorderandInorderTraversal
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            return Build(preorder, inorder, 0, preorder.Length - 1, 0, inorder.Length - 1);
        }

        private TreeNode Build(int[] preorder, int[] inorder, int pStart, int pEnd, int iStart, int iEnd)
        {
            if (pStart > pEnd) return null;

            var pRightEnd = pEnd;
            var iRightEnd = iEnd;
            while (preorder[pStart] != inorder[iEnd])
            {
                pEnd--;
                iEnd--;
            }

            var root = new TreeNode(preorder[pStart])
            {
                right = Build(preorder, inorder, pEnd + 1, pRightEnd, iEnd + 1, iRightEnd),
                left = Build(preorder, inorder, pStart + 1, pEnd, iStart, iEnd - 1)
            };
            return root;
        }
    }
}
