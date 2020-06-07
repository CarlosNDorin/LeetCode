using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class PartitionEqualSubsetSum
    {
        public bool CanPartition(int[] nums)
        {
            int sum = 0;
            foreach(int i in nums)
            {
                sum += i;
            }
            int target = sum / 2;
            return PartitionSum(nums, 0, target);
        }

        public bool PartitionSum(int[] nums, int index, int target)
        {
            if (target == 0)
                return true;



        }
    }
}
