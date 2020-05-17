using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Trapping_Rain_Water
    {
        public int Trap(int[] height)
        {
            if (height.Length < 3) return 0;

            int res = 0;
            int left = 1;
            int right = height.Length - 2;
            int maxLeft = height[0];
            int maxRight = height[height.Length - 1];
            while (left <= right)
            {
                maxLeft = Math.Max(maxLeft, height[left]);
                maxRight = Math.Max(maxRight, height[right]);

                if (maxLeft < maxRight)
                {
                    res += maxLeft - height[left++];
                }
                else
                {
                    res += maxRight - height[right--];
                }
            }
            return res;
        }
    }
}
