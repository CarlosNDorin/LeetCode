using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class PlusOne
    {
         public int[] plusOne(int[] digits)
         {
            bool carry = true;
            List<int> listDigits = digits.ToList();
            int digitsLenght = listDigits.Count();
            int index = digitsLenght - 1;
            listDigits[index] += 1;
            if(listDigits[index] < 10)
            {
                return listDigits.ToArray();
            }
            while (carry == true)
            { 
                if (listDigits[index] < 10)
                {
                    carry = false;
                }
                else
                {
                    listDigits[index] %= 10;
                    index--;
                    if( index < 0)
                    {
                        listDigits.Insert(0, 1);
                        carry = false;
                    }
                    else
                    {
                        listDigits[index] += 1;
                    }
                }
            }
            return listDigits.ToArray();
         }
    }
}
