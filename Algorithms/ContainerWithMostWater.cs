using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {

            int maxArea = 0;
            
            int heightLenght = height.Length;
            int pointerStart = 0;
            int pointerEnd = heightLenght - 1;
            int maxAreaStart = 0;
            int maxAreaEnd = heightLenght - 1;
            maxArea = Math.Min(height[pointerStart], height[pointerEnd]) * (pointerEnd - pointerStart);
            int maxAreaActual = maxArea;
            while (pointerEnd != pointerStart)
            {
                if (height[pointerStart] >= height[pointerEnd])
                    pointerEnd--;
                else
                    pointerStart++;
                maxAreaActual = Math.Min(height[pointerStart], height[pointerEnd]) * (pointerEnd - pointerStart);
                if (maxArea< maxAreaActual)
                {
                    maxArea = maxAreaActual;
                    maxAreaStart = pointerStart;
                    maxAreaEnd = pointerEnd;
                }
            }
            return maxArea;
        }
    }
}
