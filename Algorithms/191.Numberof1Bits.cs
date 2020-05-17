using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Numberof1Bits
    {
        public int HammingWeight(uint n)
        {
            int count = 31;
            int result = 0;
            while(count >=0)
            {
                if((n & 1)==1)
                {
                    result++;
                }
                n >>= 1;
            }
            return result;
        }
    }
}


