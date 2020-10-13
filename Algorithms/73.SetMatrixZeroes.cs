using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class SetZeroesMatrix
    {
        public void SetZeroes(int[][] matrix)
        {
            int rowLength = matrix.Length;
            if (rowLength == 0)
                return;
            int colLength = matrix[0].Length;
            bool firstRow = false;
            bool firstCol = false;

            for(int col = 0; col < colLength; col++)
            {
                for(int row = 0; row < rowLength; row++)
                {
                    if(matrix[row][col]==0)
                    {
                        matrix[0][col] = 0;
                        matrix[row][0] = 0;

                        if (row == 0)
                            firstRow = true;
                        if (col == 0)
                            firstCol = true;
                    }
                    
                }
            }

            for(int col = 1; col < colLength; col++)
            {
                for(int row = 1; row < rowLength; row++)
                {
                    if (matrix[0][col] == 0 || matrix[row][0] == 0)
                        matrix[row][col] = 0;
                }
            }

           if(firstRow)
           {
                for(int col = 0; col< colLength; col++)
                {
                    matrix[0][col] = 0;
                }
           }

            if (firstCol)
            {
                for(int row = 0; row < rowLength; row++)
                {
                    matrix[row][0] = 0;
                }
            }
        }
    }
}
