using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class ContainsDuplicateII
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();

            for(int i = 0; i < nums.Length; i++)
            {

                if (!dic.ContainsKey(nums[i]))
                {
                    dic.Add(nums[i], new List<int>() { i });
                }
                else
                {
                    foreach (int index in dic[nums[i]])
                    {
                        if (Math.Abs(index - i) <= k)
                            return true;
                    }
                    dic[nums[i]].Add(i);
                }
            }
            return false;
        }
    }
}
