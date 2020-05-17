using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class FindFirstandLastPositionofElementinSortedArray
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int[] answer = { -1, -1 };
            if (nums.Length == 0)
                return answer;
            if (nums.Length == 1 && nums[0] == target)
            {
                answer[0] = 0;
                answer[1] = 0;
                return answer;
            }

            int found = binarySearch(nums, target, 0, nums.Length - 1);
            if (found == -1)
                return answer;
            int searchAroundPivot = found;
            while (searchAroundPivot <= nums.Length - 1 && nums[searchAroundPivot]==target)
            {
                answer[1] = searchAroundPivot;
                searchAroundPivot++;
            }
            searchAroundPivot = found;
            while(searchAroundPivot  >= 0 && nums[searchAroundPivot] == target )
            {
                answer[0] = searchAroundPivot;
                searchAroundPivot--;
            }
             return answer;
        }

        public int binarySearch(int[] nums, int target, int start, int end)
        {
            if (start > end)
                return -1;
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
