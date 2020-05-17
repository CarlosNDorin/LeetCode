using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class SameTree
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
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            List<string> plist = new List<string>();
            List<string> qlist = new List<string>();
            preOrder(plist, p);
            preOrder(qlist, q);
            if (plist.Count() != qlist.Count())
                return false;
            for(int i = 0; i < plist.Count()-1; i++)
            {
                if (plist[i] != qlist[i])
                    return false;
            }

            return true;
        }

        private void preOrder(List<string> elements, TreeNode node)
        {
            if(node == null)
            {
                elements.Add("null");
                return;
            }

            elements.Add(node.val.ToString());
            preOrder(elements, node.left);
            preOrder(elements, node.right);
        }
    }
}
