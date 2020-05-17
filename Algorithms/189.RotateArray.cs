using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class RotateArray
    {
        public void Rotate(int[] nums, int k)
        {
            int lenght = nums.Length-1;
            int pivot = 0;
            List<int> numsList = nums.ToList();
            for (int i = 0; i < k; i++)
            {
                pivot = numsList[lenght];
                numsList.Insert(0, pivot);
                numsList.RemoveAt(lenght+1);
            }
            int count = 0;
            foreach(int j in numsList)
            {
                nums[count] = j;
                count++;
            }
        }
    }
}
