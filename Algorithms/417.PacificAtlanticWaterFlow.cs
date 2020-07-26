using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class PacificAtlanticWaterFlow
    {
        public IList<IList<int>> PacificAtlantic(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            bool[,] pacificMap = new bool[rows,cols];
            bool[,] atlanticMap = new bool[rows, cols];


            Queue<int> pacific = new Queue<int>();
            Queue<int> atlantic = new Queue<int>();

            for(int r = 0; r < rows; r++ )
            {
                pacificMap[r, 0] = true;
                pacific.Enqueue(r);
                pacific.Enqueue(0);

                atlanticMap[r, cols - 1] = true;
                atlantic.Enqueue(r);
                atlantic.Enqueue(cols - 1);
            }

            for(int c = 0; c< cols;c++)
            {
                pacificMap[0, c] = true;
                pacific.Enqueue(0);
                pacific.Enqueue(c);

                atlanticMap[rows - 1, c] = true;
                atlantic.Enqueue(rows - 1);
                atlantic.Enqueue(c);
            }


            Traverse(matrix, pacific, pacificMap);
            Traverse(matrix, atlantic, atlanticMap);

            IList<IList<int>> results = new List<IList<int>>();
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (pacificMap[r, c] && atlanticMap[r, c])
                    {
                        results.Add(new int[] { r, c });
                    }
                }
            }
            return results;

        }


        public void Traverse(int[,] matrix, Queue<int> queue, bool[,] visited )
        {

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            while (queue.Count > 0)
            {
                int r = queue.Dequeue();
                int c = queue.Dequeue();

                // left
                if (rows > 0 && !visited[r, c] && matrix[r - 1,c] >= matrix[r,c])
                {
                    visited[r - 1, c] = true;
                    queue.Enqueue(r - 1);
                    queue.Enqueue(c);
                }

                // right
                if (r < rows - 1 && !visited[r + 1, c] && matrix[r + 1, c] >= matrix[r,c])
                {
                    visited[r + 1, c] = true;
                    queue.Enqueue(r + 1);
                    queue.Enqueue(c);
                }

                // up
                if (c > 0 && !visited[r, c - 1] && matrix[r, c - 1] >= matrix[r,c])
                {
                    visited[r, c - 1] = true;
                    queue.Enqueue(r);
                    queue.Enqueue(c - 1);
                }

                // down
                if (c < cols - 1 && !visited[r, c + 1] && matrix[r,c + 1] >= matrix[r,c])
                {
                    visited[r, c + 1] = true;
                    queue.Enqueue(r);
                    queue.Enqueue(c + 1);
                }
            }
        }
    }
}
