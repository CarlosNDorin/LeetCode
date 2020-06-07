using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class ThirdMaximumNumber
    {
        public int ThirdMax(int[] nums)
        {
            var first = Int64.MinValue;
            var second = Int64.MinValue;
            var third = Int64.MinValue;

            for(int i = 0; i< nums.Length; i++ )
            {
                if (nums[i] == first || nums[i] == second || nums[i] == third)
                    continue;
                if(nums[i] > first)
                {
                    third = second;
                    second = first;
                    first = nums[i];
                }
                else if( nums[i] > second)
                    {
                        third = second;
                        second = nums[i];
                    }   
                    else if(nums[i]> third)
                        {
                            third = nums[i];
                        }
            }

            if(third==Int64.MinValue)
            {
                return (int)first;
            }
            return (int)third;
        }
    }
}
