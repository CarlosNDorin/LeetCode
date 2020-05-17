using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class UglyNumber
    {
		public bool IsUgly(int num)
	    {
            if (num == 0)
                return false;
            List<int> divisors = new List<int>() { 2, 3, 5 };
            while (divisors.Count !=0)
            {
				if(num % divisors.Last() != 0)
                {
                    divisors.RemoveAt(divisors.Count - 1);
                }
				else
                {
                    num /= divisors.Last();
                }
            }

            if ( num == 1 || num == -1)
                return true;
            else
				return false;

		}
	}
}

