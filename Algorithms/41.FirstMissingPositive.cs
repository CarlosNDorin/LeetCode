using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class First_Missing_Positive
    {
         public int FirstMissingPositive(int[] nums)
         {
            HashSet<int> hash = new HashSet<int>(); 
            foreach (int n in nums)
            {
                if (n <= 0)//I dont want the negatives
                    continue;
                hash.Add(n);
            }
            for(int i = 1;i<=Int32.MaxValue;i++)
            {
                if (!hash.Contains(i))
                    return i;
            }
            return Int32.MaxValue; ;
         }


    }
}
