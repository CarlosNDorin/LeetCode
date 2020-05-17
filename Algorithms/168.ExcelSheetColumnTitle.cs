using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class ExcelSheetColumnTitle
    {
        public string ConvertToTitle(int n)
        {
            StringBuilder res = new StringBuilder();
            while (n > 0)
            {
                n--;
                res.Append((char)(n % 26 + 'A'));
                n = n / 26;
            }
            return new string(res.ToString().Reverse().ToArray());
        }
    }
}
