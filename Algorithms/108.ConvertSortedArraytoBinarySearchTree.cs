using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class ConvertSortedArraytoBinarySearchTree
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
        
        public TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums.Length == 0)
                return null;
            return SortedArrayToBSTHelper(nums, 0, nums.Length - 1);
        }
        public TreeNode SortedArrayToBSTHelper(int[] nums, int start, int end)
        {
            int mid = (start + end) / 2;
            TreeNode node = new TreeNode(nums[mid]);
            if (start < mid)
                node.left = SortedArrayToBSTHelper(nums, start, mid - 1);
            if (mid < end)
                node.right = SortedArrayToBSTHelper(nums, mid + 1, end);
            return node;
        }
    }
}
