using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Maximum_Subarray
    {
        public int MaxSubArray(int[] nums)
        {
            int[] result = new int[nums.Length];
            result[0] = nums[0];
            for (int i = 1; i<nums.Length;i++)
            {
                result[i] = Math.Max(nums[i], nums[i] + result[i - 1]);
            }
            return result.Max();
        }
    }
}
