using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class SingleNumber
    {
        public int singleNumber(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for(int i = 0;i<nums.Length;i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]]++;
                }
                else
                {
                    dict.Add(nums[i], 1);
                }
            }
            foreach(KeyValuePair<int,int> keyValuePair in dict)
            {
                if (keyValuePair.Value == 1)
                    return keyValuePair.Key;
            }
            return 0;
        }
    }
}
