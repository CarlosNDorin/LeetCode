using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class SumofLeftLeaves
    {
        public static int values = 0;
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        public int sum = 0;
        public int SumOfLeftLeaves(TreeNode root)
        {
            Traversal(root, null);
            return sum;
        }

        private void Traversal(TreeNode actual, TreeNode parent)
        {
            if (actual == null)
                return;

            Traversal(actual.left, actual);
            if(actual.left == null && actual.right == null
                && parent!=null && parent.left == actual)
            {
                sum += actual.val;
            }
            Traversal(actual.right, actual);
        }
        
    }
}
