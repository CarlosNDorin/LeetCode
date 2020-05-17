using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class MoveZeroes
    {
        public void Movezeroes(int[] nums)
        {
            int pointer1 = 0;
            int pointer2 = 0;

            while(pointer2 < nums.Length)
            {
                if(nums[pointer2]!=0)
                {
                    nums[pointer1] = nums[pointer2];
                    pointer1++;
                    pointer2++;
                }
                else
                {
                    pointer2++;
                }
            }
            while(pointer1 < nums.Length)
            {
                nums[pointer1] = 0;
                pointer1++;
            }
        }
    }
}
