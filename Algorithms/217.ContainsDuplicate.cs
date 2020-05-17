using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class ContainsDuplicate
    {
        public bool Containsduplicate(int[] nums)
        {
            HashSet<int> hash = new HashSet<int>();

            for(int i = 0; i<nums.Length;i++)
            {
                if (hash.Contains(nums[i]))
                    return true;
                hash.Add(nums[i]);
            }
            return false;
        }
    }
}
