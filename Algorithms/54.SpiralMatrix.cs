using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class SpiralMatrix
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
            {
                return new int[0]; //Check that the matrix is ok.
            }

            int rows = matrix.Length;  // Checking the lenght of the matrix
            int cols = matrix[0].Length; // Could be a square or a rectangle!

            var spiral = new int[rows * cols];

            var directions = new int[4, 2] //El mapa para controlar las direcciones.
            {
                {0,1},
                {1,0},
                {0,-1},
                {-1,0}
            };

            //Init
            int FirstRow = 0;
            int LastRow = rows - 1;
            int FirstCol = 0;
            int LastCol = cols - 1;

            int direction = 0;
            int totalOfcells = rows * cols; ;
            int index = 0;

            int row = 0;
            int col = 0;

            //Loop

            while (index < totalOfcells)
            {
                spiral[index] = matrix[row][col];// Add value to the answer array
                index++;

                var nextRow = row + directions[direction, 0]; // Move by the directions table
                var nextCol = col + directions[direction, 1];

                if(!(nextRow >= FirstRow && nextRow <= LastRow && nextCol >= FirstCol && nextCol <= LastCol )) // If I passed the range
                {
                    switch(direction) //Short the matrix
                    {
                        case 0:
                            FirstRow++;
                            break;
                        case 1:
                            LastCol--;
                            break;
                        case 2:
                            LastRow--;
                            break;
                        case 3:
                            FirstCol++;
                            break;
                    }

                    direction = (direction + 1) % 4;
                }

                row += directions[direction, 0];
                col += directions[direction, 1];
            }
            return spiral;
        }
    }
}
