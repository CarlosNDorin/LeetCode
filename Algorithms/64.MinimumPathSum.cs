using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class MinimumPathSum
    {
        public int MinPathSum(int[][] grid)
        {
            int lengthY = grid.GetLength(0);
            int lenghtX = grid[0].Length;
            int y = lengthY - 1;
            int x = lenghtX - 1;

            int[,] dp = new int[ y + 1 , x + 1];
            dp[y, x] = grid[y][x];
            
            if (lengthY == 1 && lenghtX == 1)
                return grid[0][0];

            for(int i = y - 1; i >= 0 ; i--)
            {
                dp[i, x] = grid[i][x] + dp[ i+1, x]; 
            }

            for (int i = x - 1; i >= 0; i--)
            {
                dp[y, i] = grid[y][i] + dp[y,i+1];
            }


            for(int i = y - 1; i >=0; i-- )
            {
                for(int j = x - 1; j >=0; j--)
                {
                    dp[i, j] = Math.Min(dp[i+1,j]+grid[i][j], dp[i,j+1]+grid[i][j]);
                }
            }
            return dp[0, 0];
        }
    }
}
