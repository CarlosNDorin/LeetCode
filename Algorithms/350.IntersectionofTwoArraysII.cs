using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class IntersectionOfTwoArraysII
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            List<int> result = new List<int>();
            List<int> num2 = new List<int>(nums2);
            if (nums1.Length == 0 || nums2.Length == 0)
                return result.ToArray();

            foreach(var n in nums1)
            {
                if(num2.Contains(n))
                {
                    result.Add(n);
                    num2.Remove(n);
                }
            }
            return result.ToArray();
        }
    }
}
