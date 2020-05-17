using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class PathSum
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
        public bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null)
                return false;

            return DSF(root, sum);
        }
        public bool DSF(TreeNode root, int target)
        {
            if (root == null)
                return false; // dead end What if val is negative?
            if (root.left == null && root.right == null && root.val == target)
                return true;

            return DSF(root.left, target - root.val) || DSF(root.right, target - root.val);
        }
    }
}
