using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class TwoSumIIInputarrayissorted
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            HashSet<int> table = new HashSet<int>();
            for (int i = 0; i< numbers.Length-1;i++)
            {
                if (table.Contains(numbers[i]))
                    break;
                table.Add(numbers[i]);
                for(int j = i+1; j<numbers.Length;j++)
                {
                    if ((numbers[i] + numbers[j]) == target)
                        return new int[] { i+1, j+1 };
                    if ((numbers[i] + numbers[j]) > target)
                        break;
                }
            }
            return new int[] { 0, 0 };
        }
    }
}
