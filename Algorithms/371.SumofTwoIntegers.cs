using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class SumofTwoIntegers
    {
        public int GetSum(int a, int b)
        {
            if (b == 0) return a;

            var noCarry = a ^ b;
            var carry = a & b;

            return GetSum(noCarry, carry << 1);
        }
    }
}
