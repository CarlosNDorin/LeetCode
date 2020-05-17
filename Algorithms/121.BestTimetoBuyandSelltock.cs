using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class BestTimetoBuyandSellStock
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length == 0)
                return 0;
            int min = Int32.MaxValue;
            int max = 0;

            for(int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < min)
                    min = prices[i];
                else
                {
                    max = Math.Max(max, prices[i] - min);
                }
            }

            return max;
            
        }
    }
}
