using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Remove_Duplicates_from_Sorted_Array
    {
        //This is receiving a point to a array, so we modify the array and return the new lenght that the
        //user should read from the new array.
        public int removeDuplicatesfromSortedArray(int[] nums)
        {
            if (nums.Length == 0)
                return 0;
           int j = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[j])
                {
                    j++;
                    nums[j] = nums[i];
                }
            }
            return j + 1;
        }
    }
}
