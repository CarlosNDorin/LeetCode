using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class MajorityElement
    {
        public int Majorityelement(int[] nums)
        {
            Dictionary<int,int> dic = new Dictionary<int,int>();

            if (nums.Length == 0)
                return 0;
            foreach (int i in nums)
            {
                if (!dic.ContainsKey(i))
                {
                    dic.Add(i, 1);
                }
                else
                {
                    dic[i]++;
                }
                if (dic[i] > nums.Length / 2)
                    return i;
            }
            return 1;
        }
    }
}
