using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class ValidPerfectSquare
    {
        public bool IsPerfectSquare(int num)
        {
            if (num < 1) return false;
            if (num == 1) return true;
            long min = 1;
            long max = num;
            while (min <= max)
            {
                long mid = (min + max) / 2;
                if (mid * mid == num)
                    return true;
                if (mid * mid > num)
                    max = mid - 1;
                else
                    min = mid + 1;
            }
            return false;
        }
    }
}
