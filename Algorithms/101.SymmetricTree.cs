using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class SymmetricTree
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
        public TreeNode createTree()
        {
            TreeNode A = new TreeNode(1);
            TreeNode B = new TreeNode(2);
            TreeNode C = new TreeNode(2);
            TreeNode D = new TreeNode(3);
            TreeNode E = new TreeNode(3);
            TreeNode F = new TreeNode(3);
            TreeNode G = new TreeNode(3);

            A.left = B;
            A.right = C;

            B.left = D;
            B.right = E;

            C.left = F;
           C.right = G;

            return A;
        }
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
                return true;

            return IsSymmetricTree(root.left, root.right);
        }
        public bool IsSymmetricTree(TreeNode left, TreeNode right)
        {
            if (left == null || right == null)
                return left == right;

            if (left.val != right.val)
                return false;
            return IsSymmetricTree(left.left, right.right) && IsSymmetricTree(left.right, right.left);
        }
    }
}
