using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class MaximumDepthofBinaryTree
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
        public int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;
            return Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
        }
    }
}
