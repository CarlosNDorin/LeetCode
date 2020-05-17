using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class NQueensII
    {
        public int TotalNQueens(int n)
        {
            Tuple<int, int>[] positions = new Tuple<int, int>[n];
            List<IList<string>> results = new List<IList<string>>();
            Solve(0, n, positions, results);
            return results.Count();
        }
    

    public void Solve(int row, int max, Tuple<int, int>[] positions, List<IList<string>> results)
    {
        if (row == max)
        {
            List<string> rows = new List<string>();
            for (int stringrow = 0; stringrow < max; stringrow++)
            {
                StringBuilder sb = new StringBuilder();
                for (int stringcol = 0; stringcol < max; stringcol++)
                {
                    if (positions[stringrow].Item2 == stringcol)
                    {
                        sb.Append("Q");
                    }
                    else
                    {
                        sb.Append(".");
                    }
                }
                rows.Add(sb.ToString());
            }
            results.Add(rows);
        }
        else
        {
            for (int col = 0; col < max; col++)
            {
                bool foundSafe = true;
                for (int prevQueen = 0; prevQueen < row; prevQueen++)
                {
                    if (positions[prevQueen].Item2 == col ||
                       positions[prevQueen].Item1 + positions[prevQueen].Item2 == row + col ||
                       positions[prevQueen].Item1 - positions[prevQueen].Item2 == row - col)
                    {
                        foundSafe = false;
                        break;
                    }
                }
                if (foundSafe)
                {
                    positions[row] = new Tuple<int, int>(row, col);
                    Solve(row + 1, max, positions, results);
                }
            }
        }
    }

    }
}

