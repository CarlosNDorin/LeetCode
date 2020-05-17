using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class MissingNumber
    {
        public int Missingnumber(int[] nums)
        {
            int sum = 0;
            int length = nums.Length - 1;
            int max = 0;
            bool zero = false;
            if (nums.Length == 1 && nums[0] == 0)
                return 1;

            for(int i = 0; i <= length;i++)
            {
                sum += nums[i];
                if (max < nums[i])
                    max = nums[i];
            }
            for (int i = 0; i <=max; i++)
            {
                sum -=i;
            }
            if (sum == 0 && nums.Contains(0))
                return max + 1;
            return Math.Abs(sum);
        }
    }
}
