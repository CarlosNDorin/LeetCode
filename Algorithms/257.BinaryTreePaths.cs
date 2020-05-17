using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class BinaryTreePath
    {

        public class TreeNode
        {
             public int val;
             public TreeNode left;
             public TreeNode right;
             public TreeNode(int x) { val = x; }
        }

        IList<string> result = new List<string>();
        StringBuilder sb = new StringBuilder();
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            if(root != null && root.left == null && root.right == null)
            {
                result.Add(sb.Append(root.val).ToString());
                sb.Length -= root.val.ToString().Length;
            }
            else if (root != null)
            {
                string tmp = root.val + "->";
                sb.Append(tmp);
                if (root.left != null)
                    BinaryTreePaths(root.left);
                if (root.right != null)
                    BinaryTreePaths(root.right);
                sb.Length -= tmp.Length;
            }
            
            return result;
        }
    }
}
