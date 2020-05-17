using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class SqrtX
    {
        public int MySqrt(int x)
        {
            if (x == 0)
            {
                return 0;
            }

            if (x == 1)
            {
                return 1;
            }

            int start = 0;
            int end = x;
            while (start <= end)
            {
                int middle = start + (end - start) / 2;
                long powerOfTwo = (long)middle * middle; // failed test case: 2147395599

                if (powerOfTwo <= x && (middle == x || (middle + 1) * (middle + 1) > x))
                {
                    return middle; // largest one with power of 2 <= n
                }
                else if (powerOfTwo <= x)
                {
                    start = middle + 1;
                }
                else
                {
                    end = middle - 1;
                }
            }

            return end; // should not be -1. I choose to return end
        }
    }
}
