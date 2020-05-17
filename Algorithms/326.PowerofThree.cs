using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class PowerofThree
    {
        public bool IsPowerOfThree(int n)
        {
            if (n == 0)
                return false;
            if (Math.Pow(3, (Math.Log(n) / Math.Log(3))) == n)
                return true;
            return false;
        }
        public int MyProperty { get; set; }
    }
}
