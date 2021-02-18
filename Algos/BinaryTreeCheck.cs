using Algos.Tree;

namespace Algos
{
    public static class BinaryTreeCheck
    {
        public static bool IsBinaryTree(Node node)
        {
            if (node is null)
                return true;

            if (node.left?.val >= node.val)
            {
                return false;
            }

            if (node.right?.val <= node.val)
            {
                return false;
            }
            return IsBinaryTree(node.left) && IsBinaryTree(node.right);

        }
    }
}