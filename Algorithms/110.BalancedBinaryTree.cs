using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class BalancedBinaryTree
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
            TreeNode C = new TreeNode(3);
            TreeNode D = new TreeNode(4);
            TreeNode E = new TreeNode(5);
            TreeNode F = new TreeNode(6);
            TreeNode G = new TreeNode(7);

            A.left = B;
            A.right = C;

            B.left = D;
            B.right = E;

            C.left = F;
            C.right = G;

            return A;
        }
        public bool IsBalanced(TreeNode root)
        {
            if (CheckBalanced(root) == -1)
                return false;
            return true;
        }

        public int CheckBalanced(TreeNode root)
        {
           
                if (root == null) return 0;

                int left = CheckBalanced(root.left);
                if (left == -1) return -1;

                int right = CheckBalanced(root.right);
                if (right == -1) return -1;

                int diff = Math.Abs(left - right);

                if (diff > 1) return -1;
                return 1 + Math.Max(left, right);

            
        }
    }
}
