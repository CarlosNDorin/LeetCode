using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class FirstBadVersion
    {
            public int FirstbadVersion(int n)
            {
                int left = 0;
                int right = n;
                while (left < right)
                {
                    int mid = left + (right - left) / 2;
                   /* if (IsBadVersion(mid))
                    {
                        right = mid;
                    }
                    else
                    {
                        left = mid + 1;
                    }*/
                }
                return left;
            }
        }
}
