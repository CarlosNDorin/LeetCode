using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            int answer = 0;
            answer = binarySearch(nums, target, 0, nums.Length - 1);

            return answer;
        }
        public int binarySearch(int[] nums, int target, int start, int end)
        {
            if (start > end)
                return start;
            int mid = (start + end) / 2;

            if (nums[mid] == target)
                return mid;

            if (nums[mid] > target)
                return binarySearch(nums, target, start, mid - 1);
            else
                return binarySearch(nums, target, mid + 1, end);

        }
    }
}
