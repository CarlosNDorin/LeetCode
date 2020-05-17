using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class DivideTwoIntegers
    {
        public int Divide(int dividend, int divisor)
        {

            int sign;
            if (dividend == Int32.MinValue && divisor == -1)
                return Int32.MaxValue; //si es -2^32 ----> 2^32-1

            if (divisor > 0 ^ dividend > 0)
                sign = -1;
            else
                sign = 1;
            //Guardo el signo.

            long divid = Math.Abs(dividend);
            long divis = Math.Abs(divisor);
            //Pongo todo en positivo
            int ans = 0;

            while (divid >= divis) // 10/3
            {
                long temp = divis;
                int m = 1;

                while(temp << 1 <= divid) //6 pero aun no lo mueve, onda "next"
                {
                    temp <<= 1; //*2
                    m <<= 1; //cuento las cantidad de veces que multiplica por 2
                }
                divid -= temp; // si me paso.., vuelvo a restar
                ans += m;
            }
            if (sign == -1)
                return -ans;
            else
                return ans;
        }
    }
}
