using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * There are two sorted arrays nums1 and nums2 of size m and n respectively.

Find the median of the two sorted arrays. The overall run time complexity should be O(log (m+n)).

You may assume nums1 and nums2 cannot be both empty.

Example 1:

nums1 = [1, 3]
nums2 = [2] ---->[1,2,3] ---> (3+1)/2 -->[2]--->2

The median is 2.0
Example 2:

nums1 = [1, 2]
nums2 = [3, 4] ----> [1,2,3,4] --->hay dos merideans, 2 y 3. en n/2 y en (n/2)+1 

The median is (2 + 3)/2 = 2.5

 
A median, informally, is
the “halfway point” of the set. When n is odd, the median is unique, occurring at
i = (n+1)/2. When n is even, there are two medians, occurring at i = n/2 and
i = (n/2)+1. Thus, regardless of the parity of n, medians occur at i =(n+1)/2
(the lower median) and i =(n+1)/2 (the upper median). For simplicity in
this text, however, we consistently use the phrase “the median” to refer to the lower
median.
     */

namespace Algorithms
{
    class medianOfTwoSortedArrays
    {
            // Function to merge array in  
            // sorted order 
            public void sortedMerge(int[] array1, int[] array2)
        {
            int indexArray1 = 0, indexArray2 = 0, indexResult = 0;
            int[] result = new int[array1.Length + array2.Length];
            double resultDouble;
            while (indexArray1 < array1.Length && indexArray2 < array2.Length)
            {
                if (array1[indexArray1] <= array2[indexArray2])
                {
                    result[indexResult] = array1[indexArray1];
                    indexArray1 += 1;
                    indexResult += 1;
                }
                else
                {
                    result[indexResult] = array2[indexArray2];
                    indexArray2 += 1;
                    indexResult += 1;
                }
            }
            while (indexArray1 < array1.Length)
            {
                result[indexResult] = array1[indexArray1];
                indexArray1 += 1;
                indexResult += 1;
            }
            while (indexArray2 < array2.Length)
            {
                result[indexResult] = array2[indexArray2];
                indexArray2 += 1;
                indexResult += 1;
            }
            int res = 0;
            if (result.Length % 2 != 0)
            {
                resultDouble = result[(result.Length / 2)];
                Console.WriteLine(resultDouble);
            }
            else
            {
                res = (result.Length / 2);
                resultDouble = (result[res] + result[res - 1]);
                resultDouble = resultDouble / 2;
                Console.WriteLine( resultDouble);
            }
            }
    }   
}