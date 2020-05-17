using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class NumArray
    {
        int[] numbers;
        public NumArray(int[] nums)
        {
            numbers = new int[nums.Length+1];
            numbers[0] = 0;
            for(int i = 1; i<=nums.Length;i++)
            {
                numbers[i] = numbers[i - 1] + nums[i-1];
            }
        }

        public int SumRange(int i, int j)
        {
            if (i == 0)
            {
                return numbers[j+1];
            }
            else
            {
                return numbers[j+1] - numbers[i - 1];
            }
        }
    }
}
