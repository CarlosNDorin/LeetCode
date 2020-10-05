using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class UniquePaths
    {
        public int Unique_Paths(int m, int n)
        {

            int[,] dp = new int[n, m];
            if (m == 1 || n == 1)
                return 1;

            int pointX = n - 1 ;
            int pointY = m - 1;
            dp[pointX, pointY] = 0;

            for(int i = 0; i <= pointX; i++)
            {
                dp[i, pointY] = 1;
            }
            for(int i = 0; i <= pointY; i++)
            {
                dp[pointX, i] = 1;
            }

            for(int i = pointX-1; i >= 0; i--)
            {
                for(int j = pointY-1 ;j >= 0; j--)
                {
                    dp[i, j] = dp[i + 1, j] + dp[i, j + 1];
                }
            }

            return dp[0,0];
        }
    }
}
