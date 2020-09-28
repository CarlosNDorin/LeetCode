using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class SpiralMatrixII
    {
        public int[][] GenerateMatrix(int n)
        {
            int[][] res = new int[n][];
            for(int i = 0; i < n; i++)
            {
                res[i] = new int[n];
            }
            int col = 0;
            int row = 0;
            int num = 1;

            res[col][row] = num;
            if (n == 1)
                return res;

            num++;
            row++;

            while(num <= n*n)
            {
                while (row <= n - 1 && res[col][row] == 0)
                {
                    res[col][row] = num;
                    num++;
                    row++;
                }
                row--;
                col++;
                while (col <= n - 1 && res[col][row] == 0)
                {
                    res[col][row] = num;
                    num++;
                    col++;
                }
                col--;
                row--;
                while (row >= 0 && res[col][row] == 0)
                {
                    res[col][row] = num;
                    num++;
                    row--;
                }
                row++;
                col--;
                
                while (row >= 0 && res[col][row] == 0)
                {
                    res[col][row] = num;
                    num++;
                    col--;
                }
                row++;
                col++;
            }
                        return res;

        }
    }
}
