using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class IntersectionofTwoArrays
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            return nums1.Intersect(nums2).ToArray();
          /*  int nums1Length = nums1.Length;
            int[] result = new int[] { };
            if(nums1.Count() ==0 || nums2.Count() == 0)
            {
                return result;
            }
            for(int i = 0; i < nums1Length; i++)
            {
                if(nums2.Contains(nums1[i]) && result.Contains(nums1[i]))
                {
                  var x =  nums1.Intersect(nums2);
                }
            }*/
        }
    }
}
