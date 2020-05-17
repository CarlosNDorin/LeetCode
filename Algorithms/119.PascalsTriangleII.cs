using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class PascalsTriangleII
    {
        public IList<int> GetRow(int rowIndex)
        {
            IList<int> result = new List<int>();
            int pointer1 = 0;
            int pointer2 = 1;
            if (rowIndex == 0)
                return new List<int> { 1 };

            if (rowIndex == 1)
                return new List<int> { 1, 1 };
            result.Add(1);
            result.Add(1);
            IList<int> newList = new List<int>();

            for (int i = 2; i <= rowIndex; i++)
            {
               
                IList<int> actual = result;
                newList.Add(1);
                while (pointer2 < i )
                {
                    newList.Add(actual[pointer1] + actual[pointer2]);
                    pointer1++;
                    pointer2++;
                }
                newList.Add(1);
                result =  newList.ToList();
                pointer1 = 0;
                pointer2 = 1;
                newList.Clear();
            }

            return result;
        }
    }
}
