using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class BattleshipsinaBoard
    {
        public int CountBattleships(char[][] board)
        {
            int boardLenghtRow = board.Length;
            int boardLengthCol = board[0].Length;
            int amountOfShips = 0;
            bool[,] visited = new bool[boardLenghtRow, boardLengthCol];

            for(int i = 0; i < boardLenghtRow; i++)
            {
                for(int j = 0; j < boardLengthCol; j++)
                {
                    if(!visited[i,j])
                    {
                        visited[i,j] = true;
                        if(board[i][j] == 'X')
                        {
                            int goingDown = i + 1;
                            while(goingDown < boardLenghtRow && board[goingDown][j] == 'X')
                            {
                                visited[goingDown,j] = true;
                                goingDown++;
                            }
                            int goingLeft = j + 1;
                            while (goingLeft < boardLengthCol && board[i][goingLeft] == 'X')
                            {
                                visited[i,goingLeft] = true;
                                goingLeft++;
                            }
                            amountOfShips++;
                        }
                    }
                }
            }
            return amountOfShips;

        }
    }
}
