using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class AddStrings
    {
        public string Addstrings(string num1, string num2)
        {
            if (num1 == null || num1.Length == 0)
                return num2;
            if (num2 == null || num2.Length == 0)
                return num1;

            int lengthNum1 = num1.Length;
            int lenghtNum2 = num2.Length;
            int carry = 0;

            StringBuilder sb = new StringBuilder();


            for(int i = lengthNum1 - 1, j = lenghtNum2 - 1; i >= 0 || j >= 0 || carry == 1; i--, j--)
            {
                int x = i < 0 ? 0 : (num1[i] - '0'); // IF i < 0 then x = 0; else x = num1[i] - '0'
                int y = j < 0 ? 0 : (num2[j] - '0');

                var sum = x + y + carry;
                sb.Append(sum % 10);
                carry = sum / 10;
            }

            var array = sb.ToString().ToArray();
            Array.Reverse(array);
         
            return string.Join("", array);
        }
    }
}
