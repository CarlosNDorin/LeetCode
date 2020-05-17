using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class SudokuSolver
    {

        Dictionary<int, HashSet<char>> rows;
        Dictionary<int, HashSet<char>> cols;
        Dictionary<int, HashSet<char>> box;
        public void SolveSudoku(char[][] board)
        {
            rows = new Dictionary<int, HashSet<char>>();
            cols = new Dictionary<int, HashSet<char>>();
            box = new Dictionary<int, HashSet<char>>();

            //initialize Dictionary
            for (int i = 0; i < 9; i++)
            {
                rows[i] = new HashSet<char>();
                cols[i] = new HashSet<char>();
                box[i] = new HashSet<char>();
            }

            //initialize board
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    char current = board[y][x];
                    rows[y].Add(current);
                    cols[x].Add(current);
                    box[x / 3 + (y / 3) * 3].Add(current);
                }
            }

            Travel(board, 0, 0);
        }


        private bool Travel(char[][] board, int x, int y)
        {
            if (y == 9) return true;

            int nextX = (x + 1) % 9;
            int nextY = nextX == 0 ? y + 1 : y;
            int boxIdx = x / 3 + (y / 3) * 3;
            if (board[y][x] != '.') return Travel(board, nextX, nextY);

            for (char c = '1'; c <= '9'; c++)
            {
                if (rows[y].Contains(c)) continue;
                if (cols[x].Contains(c)) continue;
                if (box[boxIdx].Contains(c)) continue;

                rows[y].Add(c);
                cols[x].Add(c);
                box[boxIdx].Add(c);
                board[y][x] = c;
                if (Travel(board, nextX, nextY)) return true;
                rows[y].Remove(c);
                cols[x].Remove(c);
                box[boxIdx].Remove(c);
                board[y][x] = '.';

            }
            return false;

        }
    }
}
