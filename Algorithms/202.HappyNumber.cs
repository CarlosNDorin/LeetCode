using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class HappyNumber
    {
        public bool IsHappy(int n)
        {
            if (n <= 0) return false;
            HashSet<int> hs = new HashSet<int>();
            while (n != 1)
            {
                n = check(n);
                if (hs.Contains(n))
                    return false;
                hs.Add(n);
            }
            return true;
        }
        public int check(int n)
        {
            List<int> numbersList = new List<int>();
            while (n!= 0)
            {
                numbersList.Add(n%10);
                n = n / 10;
            }
            int result = 0;
            foreach(int i in numbersList)
            {
                result += i * i;
            }
            return result;
        }
    }
}
