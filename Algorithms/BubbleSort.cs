using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class BubbleSort
    {
        public int[] Bubble(int[]array)
        {
            //[99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 0]
            for(int i =0; i < array.Length-1;i++)
            {
                for(int j = 1; j<array.Length-i;j++)
                {
                    if(array[j-1]>array[j])
                    {
                        int temp = 0;
                        temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
                }
            }
            return array;
        }
    }
}
