using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class AddDigit
    {
        public int AddDigits(int num)
        {
            while(num.ToString().Length > 1)
            {
                num = Helper(num);
            }
            return num;
        }

        public int Helper(int num)
        {
            int numLength = num.ToString().Length;
            int sum = 0;
            for (int i = 0; i < numLength; i++)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
    }
}
