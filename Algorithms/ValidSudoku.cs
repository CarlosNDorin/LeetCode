using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class ValidSudoku
    {
        public bool IsValidSudoku(char[][] board)
        {
            Dictionary<char, bool> hashtable;
            // check columns
            for (var i = 0; i < 9; i++)
            {
                hashtable = new Dictionary<char, bool>();
                for (var j = 0; j < 9; j++)
                {
                    var value = board[i][j];
                    if (value.Equals('.'))
                    {
                        continue;
                    }

                    if (hashtable.ContainsKey(value))
                    {
                        return false;
                    }

                    hashtable.Add(value, true);
                }
            }

            // check rows
            for (var i = 0; i < 9; i++)
            {
                hashtable = new Dictionary<char, bool>();
                for (var j = 0; j < 9; j++)
                {
                    var value = board[j][i];
                    if (value.Equals('.'))
                    {
                        continue;
                    }

                    if (hashtable.ContainsKey(value))
                    {
                        return false;
                    }

                    hashtable.Add(value, true);
                }
            }

            // check squares
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    hashtable = new Dictionary<char, bool>();

                    for (var m = 0; m < 3; m++)
                    {
                        for (var n = 0; n < 3; n++)
                        {
                            var value = board[i * 3 + m][j * 3 + n];
                            if (value.Equals('.'))
                            {
                                continue;
                            }

                            if (hashtable.ContainsKey(value))
                            {
                                return false;
                            }

                            hashtable.Add(value, true);
                        }
                    }
                }
            }
            return true;
        }
    }
}
