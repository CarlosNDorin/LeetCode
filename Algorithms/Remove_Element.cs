using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Remove_Element
    {
        public int RemoveElement(int[] nums, int val)
        {
            if (nums.Count() == 0)
                return 0;
            int i = 0;
            for(int j = 0; j < nums.Count(); j++)
            {
              if(nums[j] != val)
                {
                    nums[i] = nums[j];
                    i++;
                }
            }
            return i + 1;
        }
    }
}
