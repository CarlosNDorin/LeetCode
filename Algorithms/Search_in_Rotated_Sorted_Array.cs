using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Search_in_Rotated_Sorted_Array
    {
        //O(log(n))
        public int Search(int[] nums, int target)
        {
            int begin = 0, end = nums.Length - 1;
            int len = nums.Length;
            int newStart;
            if (nums.Length == 0)
                return -1;
            //1. Loop to find out rotating point newStart
            while (begin < end)
            {
                //4,5,6,7,0,1,2,3
                //0,1,2,3,4,5,6,7

                if (nums[(begin + end) / 2] < nums[len - 1])
                    end = (begin + end) / 2;
                else if (nums[(begin + end) / 2] > nums[len - 1])
                    begin = (begin + end + 1) / 2;
            }
            newStart = nums[begin] < nums[len - 1] ? begin : end;

            //2. Loop to find out target value from newStart
            //    if the index is larger than nums.Length then subtract nums.Length to get the real index
            begin = newStart;
            end = newStart + len - 1;
            while (begin < end)
            {
                int mid = (begin + end) / 2 > len - 1 ? ((begin + end) / 2 - len) : (begin + end) / 2;
                if (nums[mid] > target)
                    end = (begin + end) / 2;
                else if (nums[mid] < target)
                    begin = (begin + end + 1) / 2;
                else
                    return mid;
            }

            if (end > len - 1) end -= len;
            return nums[end] == target ? end : -1;

        }
    }
}
