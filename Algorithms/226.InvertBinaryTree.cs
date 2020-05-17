using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class InvertBinaryTree
    {
        public class TreeNode {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null) return null;
            Queue<TreeNode> treeNodes = new Queue<TreeNode>();
            treeNodes.Enqueue(root);

            while(treeNodes.Count()!= 0)
            {
                TreeNode node = treeNodes.Dequeue();
                TreeNode tmp = node.left;

                node.left = node.right;
                node.right = tmp;
                if(node.left != null)
                    treeNodes.Enqueue(node.left);
                if(node.right != null)
                    treeNodes.Enqueue(node.right);
            }
            return root;
        }
    }
}
