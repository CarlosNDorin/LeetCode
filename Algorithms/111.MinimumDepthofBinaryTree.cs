using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class MinimumDepthofBinaryTree
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
           // TreeNode D = new TreeNode(4);
            TreeNode E = new TreeNode(5);
            TreeNode F = new TreeNode(6);
            TreeNode G = new TreeNode(7);

            A.left = B;
            A.right = C;

           // B.left = D;
          //  B.right = E;

            C.left = F;
            C.right = G;

            return A;
        }
        public int MinDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            return minDepth(root);
        }

        public int minDepth(TreeNode root)
        {
            Queue<TreeNode> roots = new Queue<TreeNode>();
            roots.Enqueue(root);
            int count = roots.Count();
            int level = 1;
            while (count != 0)
            {
                for (int i = 0; i < count; i++)
                {
                    TreeNode actual = roots.Dequeue();
                    if (actual.left == null && actual.right == null)
                        return level;
                    if (actual.left != null)
                        roots.Enqueue(actual.left);
                    if (actual.right != null)
                        roots.Enqueue(actual.right);
                }
                count = roots.Count();
                level++;
            }
            return level;
        }
    }
}


