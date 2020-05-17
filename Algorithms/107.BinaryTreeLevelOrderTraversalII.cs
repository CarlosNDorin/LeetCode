using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class BinaryTreeLevelOrderTraversalII
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
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (root == null)
                return result;
            result.Add(new List<int> { root.val });
            BFS(result, root);
            return result.Reverse().ToList();
        }
        
        public void BFS(IList<IList<int>> result, TreeNode root)
        {
            Queue<TreeNode> nodes = new Queue<TreeNode>();
            if (root == null)
                return;
            nodes.Enqueue(root);
            TreeNode dummy;
            

            while (nodes.Count() != 0)
            {
                int n = nodes.Count();
                List<int> listSons = new List<int>();
                for (int i = 0; i < n; i++)
                {
                    dummy = nodes.Dequeue();

                    if (dummy.left != null)
                    {
                        nodes.Enqueue(dummy.left);
                    }
                    if (dummy.right != null)
                    {
                        nodes.Enqueue(dummy.right);
                    }
                    listSons.Add(dummy.val);
                }
                result.Add(listSons);
            }
        }
    }
}
