using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class UniquePathsII
    {
        public int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            int x = obstacleGrid.GetLength(0);
            int y = obstacleGrid[0].Length;

            int[,] dp = new int[x, y];

            if (obstacleGrid[x - 1][y - 1] == 1)
                return 0;
            if (x == 1 && y == 1)
                if (obstacleGrid[0][0] == 1)
                    return 0;
                else
                    return 1;
            if( x== 1 || y == 1)
            {
                for(int i = 0; i < x; i++)
                {
                    for(int j = 0; j < y; j++)
                    {
                        if (obstacleGrid[i][j] == 1)
                            return 0;
                    }
                }
                return 1;
            }

            int pointX = x - 1;
            int pointY = y - 1;

            for (int i = pointX; i >= 0; i--)
            {
                if (obstacleGrid[i][pointY] == 0)
                    dp[i, pointY] = 1;
                else
                    break;
            }
            for (int i = pointY; i >= 0; i--)
            {
                if (obstacleGrid[pointX][i] == 0)
                    dp[pointX, i] = 1;
                else
                    break;
            }
            

            for (int i = pointX - 1; i >= 0; i--)
            {
                for (int j = pointY - 1; j >= 0; j--)
                {
                    if (obstacleGrid[i][j] == 0)
                        dp[i, j] = dp[i + 1, j] + dp[i, j + 1];
                }
            }
            return dp[0, 0];
        }
    }
}
