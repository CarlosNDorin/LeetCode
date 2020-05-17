using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class MultiplyStrings
    {
        public string Multiply(string num1, string num2)
        {
            int n1 = num1.Length;
            int n2 = num2.Length;
            int[] product = new int[n1 + n2];
            if (n1 == 1 && num1 == "0")
                return "0";
            if (n2 == 1 && num2 == "0")
                return "0";


            for (int i = n1-1; i>=0; i--)
            {
                for(int j = n2-1; j>=0;j--)
                {
                    int p1 = i + j;
                    int p2 = p1 + 1;

                    int sum = (num1[i] - '0') * (num2[j] - '0') + product[p2];
                    product[p1] += sum / 10;
                    product[p2] = sum % 10;
                }
            }
            string result = string.Empty;
            foreach(int i in product)
            {
                result += i;
            }
            if (result.First() == '0')
                result = result.Remove(0, 1);
            return result;
            
        }
    }
}
