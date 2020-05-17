using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class PascalsTriangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> result = new List<IList<int>>();
            int pointer1 = 0;
            int pointer2 = 1;
            int list = 1;
            if (numRows == 0)
                return result;
            result.Add(new List<int> { 1 });
            if (numRows >= 2 )
                result.Add(new List<int> { 1,1 });

            for (int i = 3; i <= numRows; i++)
            {
                IList<int> newList = new List<int>();
                IList<int> actual = result[list];
                newList.Add(1);
                while(pointer2 < i-1)
                {
                    newList.Add(actual[pointer1] + actual[pointer2]);
                    pointer1++;
                    pointer2++;
                }
                newList.Add(1);
                list++;
                pointer1 = 0;
                pointer2 = 1;
                result.Add(newList);
            }

            return result;

        }
    }
}
