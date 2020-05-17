using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class ReverseBits
    {
       public uint reverseBits(uint n)
       {
            uint result = 0;
            uint temp = 0;
            int count = 31;
                while (count >= 0)
                {
                temp = (n & 1) << count;
                result |= temp;
                n >>= 1;
                count--;
                }

        return result;

       }
    }
}
